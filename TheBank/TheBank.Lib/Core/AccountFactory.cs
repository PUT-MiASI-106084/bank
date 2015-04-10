using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Core.AccountFactoryStates;
using TheBank.Lib.enums;

namespace TheBank.Lib.Core
{
    public class AccountFactory
    {
        AccountFactoryState state;

        private void SetState(AccountType type)
        {
            switch (type)
            {
                case AccountType.Saving:
                    this.state = new CreateSaving();
                    break;
                case AccountType.Checking:
                    this.state = new CreateChecking();
                    break;
            }

        }

        public AccountFactory()
        {
        }
        public Account CreateAccount(AccountType type)
        {
            return this.state.CreateAccount();
        }
    }
}
