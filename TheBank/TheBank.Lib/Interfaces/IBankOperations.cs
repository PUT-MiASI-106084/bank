namespace TheBank.Lib.Interfaces
{
    internal interface IBankOperations
    {
        bool Transfer(Account from, Account to, double amount);
    }
}