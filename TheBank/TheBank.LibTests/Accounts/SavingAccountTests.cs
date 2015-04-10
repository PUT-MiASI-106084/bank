using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.Accounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TheBank.Lib.Accounts.Tests
{
    [TestClass()]
    public class SavingAccountTests
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            // Arrange
            double currentBalance = 1000.0;
            int maxMTValue = 2;
            double withdrawal = 500.0;
            double expected = 500.0;
            var account = new SavingAccount(currentBalance, maxMTValue);

            // Act
            account.Withdraw(withdrawal);
            double actual = account.Balance;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
