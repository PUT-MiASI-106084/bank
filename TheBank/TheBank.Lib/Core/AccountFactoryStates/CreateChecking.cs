using TheBank.Lib.Accounts;

namespace TheBank.Lib.Core.AccountFactoryStates
{
    internal class CreateChecking : AccountFactoryState
    {
        public override Account CreateAccount()
        {
            return new CheckingAccount();
        }
    }
}