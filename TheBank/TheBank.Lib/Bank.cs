using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Core;
using TheBank.Lib.enums;

namespace TheBank.Lib
{
    public class Bank
    {
        private AccountFactory accountFactory;

        public AccountFactory AccountFactory
        {
            get { return accountFactory == null ? this.AccountFactory = new AccountFactory() : this.AccountFactory; }
            private set { accountFactory = value; }
        }

        private List<AccountOwner> _ListOfAccountOwners;

        public IEnumerable<AccountOwner> GetListOfAccountOwners()
        {
            return _ListOfAccountOwners;
        }

        public void CreateAccount(AccountOwner owner,AccountType type)
        {
            owner.AddAccount(this.AccountFactory.CreateAccount(type));
        }
    }
}
