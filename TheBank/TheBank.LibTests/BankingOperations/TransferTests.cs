using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBank.Lib.BankingOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBank.Lib.Accounts;
namespace TheBank.Lib.BankingOperations.Tests
{
    [TestClass()]
    public class TransferTests
    {
        [TestMethod()]
        public void TransferMoneyTestPositive()
        {
            //arrange
            double amount = 5;
            double formCurrentBalance = 10;
            double toCurrentBalance = 0;
            double expected = 5;
            var from = new CheckingAccount(formCurrentBalance);
            var to = new CheckingAccount(toCurrentBalance);
            //act
            Transfer.TransferMoney(from, to, amount);
            //assert
            Assert.AreEqual(from.Balance, expected);
            Assert.AreEqual(to.Balance, expected);

        }
        [TestMethod()]
        public void TransferMoneyTestNegative()
        {
            //arrange
            double amount = 5;
            double formCurrentBalance = 0;
            double toCurrentBalance = 10;
           
            var from = new CheckingAccount(formCurrentBalance);
            var to = new CheckingAccount(toCurrentBalance);
            //act
            var result  = Transfer.TransferMoney(from, to, amount);
            //assert
            Assert.AreEqual(result, false);
           
        }
    }
}
