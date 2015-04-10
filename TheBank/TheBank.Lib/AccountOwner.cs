using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib
{
    public class AccountOwner
    {
        private List<Account> _ListOfAccounts;

        public IEnumerable<Account> GetListOfAccounts()
        {
            return _ListOfAccounts;
        }

        public void AddAccount(Account account) {
            this._ListOfAccounts.Add(account);
        }
    }
}
