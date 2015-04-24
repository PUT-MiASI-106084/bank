using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Interfaces;
namespace TheBank.Lib
{
    public class AccountOwner : IAccountOwner
    {
        private List<Account> _ListOfAccounts;

        public AccountOwner() {
            this._ListOfAccounts = new List<Account>();
        }

        public IEnumerable<Account> GetListOfAccounts()
        {
            return _ListOfAccounts;
        }

        public void AddAccount(Account account) {
            this._ListOfAccounts.Add(account);
        }
    }
}
