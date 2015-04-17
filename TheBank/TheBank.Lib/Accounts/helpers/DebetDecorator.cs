using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib.Accounts.helpers
{
    public class DebetDecorator : IAccount
    {
        private double debet;
        private double MAXdebet;
        IAccount WrappedObject;

        public DebetDecorator(IAccount wrappedObject,double amount = 2000)
        {
            debet = 0;
            MAXdebet = amount;
            this.WrappedObject = wrappedObject;
        }

        public bool Withdraw(double amount)
        {
            if (this.WrappedObject.Balance >= amount)
                return this.WrappedObject.Withdraw(amount);
            else {
                if (this.WrappedObject.Balance + (this.MAXdebet - this.debet) >= amount)
                {
                    var tmpBalance = amount - this.WrappedObject.Balance;
                    this.WrappedObject.Withdraw(this.WrappedObject.Balance);
                    this.debet -= tmpBalance;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool PayIn(double amount)
        {
            if (this.debet < 0)
            {
                var tmpAmount = amount - debet;

                if (tmpAmount > 0)
                {
                    this.debet = 0;
                    return this.WrappedObject.PayIn(tmpAmount);
                }
                else
                {
                    this.debet = this.debet + amount;
                    return true;
                }
            }
            else {
                return this.WrappedObject.PayIn(amount);
            }
            
        }


        public double Balance
        {
            get
            {
                return this.WrappedObject.Balance + this.MAXdebet + this.debet;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
