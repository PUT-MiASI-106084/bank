using System.Collections.Generic;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib
{
    public class AccountOwner : IAccountOwner
    {
        private readonly List<Account> _listOfAccounts;

        public AccountOwner()
        {
            _listOfAccounts = new List<Account>();
        }

        public IEnumerable<Account> GetListOfAccounts()
        {
            return _listOfAccounts;
        }

        public void AddAccount(Account account)
        {
            _listOfAccounts.Add(account);
        }
    }
}