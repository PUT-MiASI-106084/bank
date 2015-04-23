using System;
using System.Text;

namespace TheBank.Lib.BankingOperations
{
    public class Transfer : BankingOperation
    {
        public static bool TransferMoney(TransferModel transfer)
        {
            TransferHandler amounHandler = new TransferAmountHandler();
            TransferHandler multipleHander = new MultipleHighTransferHandler();
            amounHandler.SetSuccessor(multipleHander);

            if (transfer.From.Withdraw(transfer.Amount))
            {
                amounHandler.ProcessRequest(transfer);
                return true;
            }
            return false;
        }

    }

    
}
