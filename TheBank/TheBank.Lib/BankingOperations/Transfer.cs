using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib.BankingOperations
{
    public class Transfer : BankingOperation
    {
        public static bool TransferMoney(Account from, Account to, double amount){

            if (from.Withdraw(amount))
            {
                to.PayIn(amount);
                return true;
            }
            return false;
        }

    }
}
