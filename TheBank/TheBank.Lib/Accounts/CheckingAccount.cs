namespace TheBank.Lib.Accounts
{
    public class CheckingAccount : Account
    {
        public CheckingAccount()
        {
        }

        public CheckingAccount(double initialBalance = 0)
            : base(initialBalance)
        {
        }

        public override bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}