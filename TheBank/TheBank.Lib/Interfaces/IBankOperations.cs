using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib.Interfaces
{
    interface IBankOperations
    {
        bool Transfer(Account from, Account to, double amount);
    }
}
