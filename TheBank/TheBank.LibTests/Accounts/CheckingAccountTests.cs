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
    public class CheckingAccountTests
    {
      
        [TestMethod()]
        public void WithdrawTest()
        { 
            // arrange
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new CheckingAccount(currentBalance);
            // act
            account.Withdraw(withdrawal);
            double actual = account.Balance;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PayInTest()
        {
            // arrange
            double currentBalance = 10.0;
            double payIn = 1.0;
            double expected = 11.0;
            var account = new CheckingAccount(currentBalance);
            // act
            account.PayIn(payIn);
            double actual = account.Balance;
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
