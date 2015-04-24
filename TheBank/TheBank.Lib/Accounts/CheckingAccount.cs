using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib.Accounts
{
    public class CheckingAccount : Account
    {
        public CheckingAccount()
            :base()
        {
           
        }

        public CheckingAccount(double initialBalance = 0)
            : base(initialBalance) { 
        }

        public override bool Withdraw(double amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                return true;
            }
            else {
                return false;
            }
        }
        public override bool PayIn(double amount)
        {
            return base.PayIn(amount);
        }

     
    }
}
