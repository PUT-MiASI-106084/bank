using System.Collections.Generic;

namespace TheBank.Lib.Interfaces
{
    public interface IAccountOwner
    {
        void AddAccount(Account account);
        IEnumerable<Account> GetListOfAccounts();
    }
}