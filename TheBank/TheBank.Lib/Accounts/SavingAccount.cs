namespace TheBank.Lib.Accounts
{
    public class SavingAccount : Account
    {
        public SavingAccount()
        {
        }

        public SavingAccount(double initialBalance = 0, int maxMonthTransferCounter = 10000)
            : base(initialBalance)
        {
            MaxMTValue = maxMonthTransferCounter;
        }

        public int MaxMTValue { get; set; }
        public int MonthTransferCounter { get; set; }

        public override bool Withdraw(double amount)
        {
            if (Balance >= amount && MonthTransferCounter <= MaxMTValue)
            {
                Balance -= amount;
                MonthTransferCounter++;
                return true;
            }
            return false;
        }

        public override bool PayIn(double amount)
        {
            return base.PayIn(amount);
        }
    }
}