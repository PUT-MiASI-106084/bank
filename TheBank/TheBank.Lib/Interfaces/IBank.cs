using System.Collections.Generic;
using TheBank.Lib.enums;

namespace TheBank.Lib.Interfaces
{
    public interface IBank
    {
        void CreateAccount(IAccountOwner owner, AccountType type);
        IEnumerable<AccountOwner> GetListOfAccountOwners();
    }
}