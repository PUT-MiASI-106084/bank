using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBank.Lib.Accounts;
using TheBank.Lib.Accounts.helpers;

namespace TheBank.LibTests.Accounts
{
    [TestClass]
    public class DebetDecoratorTest
    {
        [TestMethod]
        public void WithdrawTest()
        {
            // Arrange
            var currentBalance = 1000.0;
            var maxMTValue = 2;
            var withdrawal = 1500.0;
            var expected = 1500.0;
            var account = new DebetDecorator(new SavingAccount(currentBalance, maxMTValue));

            // Act
            account.Withdraw(withdrawal);
            var actual = account.Balance;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PayInTest()
        {
            // Arrange
            double currentBalance = 0;

            var maxMTValue = 2;
            var withdrawal = 1500.0;
            var expectedTotalBalance = 500.0;
            var account = new SavingAccount(currentBalance, maxMTValue);
            var debetAccount = new DebetDecorator(account);

            // Act
            debetAccount.Withdraw(withdrawal);
            var actual = debetAccount.Balance;

            // Assert
            Assert.AreEqual(expectedTotalBalance, actual);
            Assert.AreEqual(0, account.Balance);
        }
    }
}