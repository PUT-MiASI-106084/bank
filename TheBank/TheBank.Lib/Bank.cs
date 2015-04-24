using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Core;
using TheBank.Lib.enums;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib
{
    public class Bank : IBank
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

        public void CreateAccount(IAccountOwner owner,AccountType type)
        {
            owner.AddAccount(this.AccountFactory.CreateAccount(type));
        }
    }
}
