using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib.Core
{
    public abstract class AccountFactoryState
    {
        private AccountFactory accountFactory;

        public AccountFactory AccountFactory
        {
            get { return accountFactory; }
            set { accountFactory = value; }
        }

        public abstract Account CreateAccount();
        
    }
}
