using System;
using System.Text;

namespace TheBank.Lib.BankingOperations
{
    public class Transfer : BankingOperation
    {
        public static bool TransferMoney(TransferModel transfer)
        {
            TransferHandler amountHandler = new TransferAmountHandler();
            TransferHandler highAmountHandler = new TransferHighAmountHandler();
            TransferHandler multipleHander = new MultipleHighTransferHandler();
            amountHandler.SetSuccessor(highAmountHandler);
            highAmountHandler.SetSuccessor(multipleHander);

            if (transfer.From.Withdraw(transfer.Amount))
            {
                amountHandler.ProcessRequest(transfer);
                return true;
            }

            return false;
        }

    }

    
}
