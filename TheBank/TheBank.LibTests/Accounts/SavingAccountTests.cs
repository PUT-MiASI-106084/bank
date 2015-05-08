using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBank.Lib.Accounts;

namespace TheBank.LibTests.Accounts
{
    [TestClass]
    public class SavingAccountTests
    {
        [TestMethod]
        public void WithdrawTest()
        {
            // Arrange
            var currentBalance = 1000.0;
            var maxMTValue = 2;
            var withdrawal = 500.0;
            var expected = 500.0;
            var account = new SavingAccount(currentBalance, maxMTValue);

            // Act
            account.Withdraw(withdrawal);
            var actual = account.Balance;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}