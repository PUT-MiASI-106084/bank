using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib.Accounts
{
    public class SavingAccount : Account
    {
        private int _MTCounter;
        private int _MaxMTValue;

        public int MaxMTValue
        {
            get { return _MaxMTValue; }
            set { _MaxMTValue = value; }
        }

        public int MonthTransferCounter
        {
            get { return _MTCounter; }
            set { _MTCounter = value; }
        }

        public SavingAccount()
            :base()
        {

        }

        public SavingAccount(double initialBalance, int maxMonthTransferCounter)
            : base(initialBalance) {
                this.MaxMTValue = maxMonthTransferCounter;
        }

        public override bool Withdraw(double amount)
        {
            if (this.Balance >= amount && this.MonthTransferCounter <= this.MaxMTValue  ) 
            {
                this.Balance -= amount;
                this.MonthTransferCounter++;
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
