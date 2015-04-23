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

    class TransferAmountHandler : TransferHandler
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

    class MultipleHighTransferHandler : TransferHandler
    {
        public override void ProcessRequest(TransferModel transfer)
        {
            // zgłoszenie przelewu do US
            ReportToIRS(transfer);

            var history = transfer.From.AccountsHistory;

            //if !(seria takich samych przelewów)
            if (transfer.Amount > 20000.0)
            {
                transfer.To.PayIn(transfer.Amount);
            }
            else
            {
                //zamrożenie przelewu
                transfer.Status = (int) TransferState.Suspended;
            }
        }

        public void ReportToIRS(TransferModel transfer)
        { }
    }

}
