using System;
using System.Collections.Generic;
using TheBank.Lib.Core;
using TheBank.Lib.enums;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib
{
    public class Bank : IBank
    {
        private AccountFactory _accountFactory;

        public AccountFactory AccountFactory
        {
            get { return _accountFactory == null ? this.AccountFactory = new AccountFactory() : this.AccountFactory; }
            private set { _accountFactory = value; }
        }

        private List<AccountOwner> _listOfAccountOwners;

        public IEnumerable<AccountOwner> GetListOfAccountOwners()
        {
            return _listOfAccountOwners;
        }

        public void CreateAccount(IAccountOwner owner,AccountType type)
        {
            owner.AddAccount(this.AccountFactory.CreateAccount(type));
        }
    }
}
