using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib
{
    public abstract class Account : IBasicBankOperations
    {
        private double _Balance;
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }        }

        private OperationHistory _AccountsHistory;
        public OperationHistory AccountsHistory
        {
            get { return _AccountsHistory; }
            set { _AccountsHistory = value; }
        }

        private List<SmartCard> _ListOfSmartCards;
        public List<SmartCard> ListOfSmartCards
        {
            get { return _ListOfSmartCards; }
            set { _ListOfSmartCards = value; }
        }
        

        public Account()
        {
            _Balance = 0;
        }
        public Account(double initialBalance)
        {
            _Balance = initialBalance;
        }

        //public virtual bool CreateAnOperation();
        public virtual bool Withdraw(double amount){ throw new NotImplementedException();}
        public virtual bool PayIn(double amount) { 
            this.Balance += amount; 
            return true;
        }


    }
}
