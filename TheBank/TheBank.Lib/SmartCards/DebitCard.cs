using TheBank.Lib.Interfaces;

namespace TheBank.Lib.SmartCards
{
    public class DebitCard : SmartCard, IBasicBankOperations
    {
        public DebitCard()
        {
        }

        public DebitCard(Account ownerAccount)
        {
            OwnerAccount = ownerAccount;
        }

        public Account OwnerAccount { get; set; }

        public bool Withdraw(double amount)
        {
            return OwnerAccount.Withdraw(amount);
        }

        public bool PayIn(double amount)
        {
            return OwnerAccount.PayIn(amount);
        }
    }
}