using TheBank.Lib.Accounts;

namespace TheBank.Lib.Core.AccountFactoryStates
{
    internal class CreateSaving : AccountFactoryState
    {
        public override Account CreateAccount()
        {
            return new SavingAccount();
        }
    }
}