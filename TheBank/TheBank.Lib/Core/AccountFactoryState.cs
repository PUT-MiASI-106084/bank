namespace TheBank.Lib.Core
{
    public abstract class AccountFactoryState
    {
        public AccountFactory AccountFactory { get; set; }
        public abstract Account CreateAccount();
    }
}