using System;
using System.Collections.Generic;
using System.Linq;

namespace TheBank.Lib.BankingOperations
{
    public abstract class TransferHandler
    {
        protected TransferHandler Next;

        public void SetSuccessor(TransferHandler successor)
        {
            Next = successor;
        }

        public abstract void ProcessRequest(TransferModel transfer);
    }

    public class TransferAmountHandler : TransferHandler
    {
        public override void ProcessRequest(TransferModel transfer)
        {
            if (transfer.Amount < 20000.0)
            {
                transfer.To.PayIn(transfer.Amount);
            }
            else if (Next != null)
            {
                Next.ProcessRequest(transfer);
            }
        }
    }

    public class TransferHighAmountHandler : TransferHandler
    {
        public override void ProcessRequest(TransferModel transfer)
        {
            // zgłoszenie przelewu do US
            ReportToIRS(transfer);

            //pobranie historii przelewów z ostatniej godziny
            List<TransferModel> history = null;
            history.AddRange(
                transfer.From.AccountsHistory.TransfersList.Where(
                    trans => /*trans.From == transfer.From &&*/ trans.InitiationDate >= DateTime.Now.AddHours(1)));

            if (history.Count < 10)
            {
                transfer.To.PayIn(transfer.Amount);
            }
            else if (Next != null)
            {
                Next.ProcessRequest(transfer);
            }
        }

        public void ReportToIRS(TransferModel transfer)
        {
        }
    }

    public class MultipleHighTransferHandler : TransferHandler
    {
        public override void ProcessRequest(TransferModel transfer)
        {
            transfer.Status = (int) TransferState.Suspended;

            if (Next != null)
            {
                Next.ProcessRequest(transfer);
            }
        }
    }
}