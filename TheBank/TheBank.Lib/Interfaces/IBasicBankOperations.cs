namespace TheBank.Lib.Interfaces
{
    internal interface IBasicBankOperations
    {
        bool Withdraw(double amount);
        bool PayIn(double amount);
    }
}