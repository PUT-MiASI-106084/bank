using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Accounts;

namespace TheBank.Lib.Core.AccountFactoryStates
{
    class CreateChecking : AccountFactoryState
    {
        public override Account CreateAccount()
        {
            return new CheckingAccount();
        }
    }
}
