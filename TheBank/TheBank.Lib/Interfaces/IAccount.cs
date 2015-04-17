using System;
namespace TheBank.Lib.Interfaces
{
    interface IAccount
    {
        double Balance { get; set; }
        bool PayIn(double amount);
        bool Withdraw(double amount);
    }
}
