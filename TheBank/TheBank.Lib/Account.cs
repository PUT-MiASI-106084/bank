using System;
using System.Collections.Generic;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib
{
    public abstract class Account : IBasicBankOperations, IAccount
    {
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }        }

        private OperationHistory _accountsHistory;
        public OperationHistory AccountsHistory
        {
            get { return _accountsHistory; }
            set { _accountsHistory = value; }
        }

        private List<SmartCard> _listOfSmartCards;
        public List<SmartCard> ListOfSmartCards
        {
            get { return _listOfSmartCards; }
            set { _listOfSmartCards = value; }
        }
        

        public Account()
        {
            _balance = 0;
        }
        public Account(double initialBalance)
        {
            _balance = initialBalance;
        }

        //public virtual bool CreateAnOperation();
        public virtual bool Withdraw(double amount){ throw new NotImplementedException();}
        public virtual bool PayIn(double amount) { 
            Balance += amount; 
            return true;
        }


    }
}
