using System;
namespace TheBank.Lib.Interfaces
{
    public interface IBank
    {
        void CreateAccount(IAccountOwner owner, TheBank.Lib.enums.AccountType type);
        System.Collections.Generic.IEnumerable<AccountOwner> GetListOfAccountOwners();
    }
}
