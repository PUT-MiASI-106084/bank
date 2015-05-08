using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBank.Lib.Accounts;

namespace TheBank.LibTests.Accounts
{
    [TestClass]
    public class CheckingAccountTests
    {
        [TestMethod]
        public void WithdrawTest()
        {
            // arrange
            var currentBalance = 10.0;
            var withdrawal = 1.0;
            var expected = 9.0;
            var account = new CheckingAccount(currentBalance);
            // act
            account.Withdraw(withdrawal);
            var actual = account.Balance;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PayInTest()
        {
            // arrange
            var currentBalance = 10.0;
            var payIn = 1.0;
            var expected = 11.0;
            var account = new CheckingAccount(currentBalance);
            // act
            var actual = account.Balance;
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}