using System.Collections.Generic;
using TheBank.Lib.Core;
using TheBank.Lib.enums;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib
{
    public class Bank : IBank
    {
        private AccountFactory _accountFactory;
        private List<AccountOwner> _listOfAccountOwners;

        public AccountFactory AccountFactory
        {
            get { return _accountFactory == null ? AccountFactory = new AccountFactory() : AccountFactory; }
            private set { _accountFactory = value; }
        }

        public IEnumerable<AccountOwner> GetListOfAccountOwners()
        {
            return _listOfAccountOwners;
        }

        public void CreateAccount(IAccountOwner owner, AccountType type)
        {
            owner.AddAccount(AccountFactory.CreateAccount(type));
        }
    }
}