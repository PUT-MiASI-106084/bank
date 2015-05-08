using TheBank.Lib.Core.AccountFactoryStates;
using TheBank.Lib.enums;

namespace TheBank.Lib.Core
{
    public class AccountFactory
    {
        private AccountFactoryState _state;

        private void SetState(AccountType type)
        {
            switch (type)
            {
                case AccountType.Saving:
                    _state = new CreateSaving();
                    break;
                case AccountType.Checking:
                    _state = new CreateChecking();
                    break;
            }
        }

        public Account CreateAccount(AccountType type)
        {
            SetState(type);
            return _state.CreateAccount();
        }
    }
}