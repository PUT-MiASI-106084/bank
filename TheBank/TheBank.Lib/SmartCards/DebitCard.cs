using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib.SmartCards
{
    public class DebitCard : SmartCard, IBasicBankOperations
    {
        private Account _OwnerAccount;

        public Account OwnerAccount
        {
            get { return _OwnerAccount; }
            set { _OwnerAccount = value; }
        }
        public DebitCard()
            :base()
        {

        }
        public DebitCard(Account ownerAccount)
            : base()
        {
            this.OwnerAccount = ownerAccount;
        }


        public bool Withdraw(double amount)
        {
            return this.OwnerAccount.Withdraw(amount);
        }

        public bool PayIn(double amount)
        {
            return this.OwnerAccount.PayIn(amount);
        }
    }
}
