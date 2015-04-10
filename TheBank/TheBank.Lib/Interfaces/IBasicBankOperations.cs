using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank.Lib.Interfaces
{
    interface IBasicBankOperations
    {
        bool Withdraw(double amount);
        bool PayIn(double amount);
    }
}
