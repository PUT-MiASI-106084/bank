using System;
namespace TheBank.Lib.Interfaces
{
    public interface IAccountOwner
    {
        void AddAccount(Account account);
        System.Collections.Generic.IEnumerable<Account> GetListOfAccounts();
    }
}
