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
            double amount = 21000;
            double formCurrentBalance = 22000;
            double toCurrentBalance = 0;
            double expected = 1000;
            double toExpected = 21000;
            var from = new CheckingAccount(formCurrentBalance);
            var to = new CheckingAccount(toCurrentBalance);

            var model = new TransferModel()
            {
                //Id = 
                Amount = amount,
                From = from,
                InitiationDate = DateTime.Now,
                Status = 0,
                To = to
            };
            //act
            Transfer.TransferMoney(model);
            //assert
            Assert.AreEqual(from.Balance, expected);
            Assert.AreEqual(to.Balance, toExpected);

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

            var model = new TransferModel()
            {
                //Id = 
                Amount = amount,
                From = from,
                InitiationDate = DateTime.Now,
                Status = 0,
                To = to
            };
            //act
            var result = Transfer.TransferMoney(model);
            //assert
            Assert.AreEqual(result, false);
        }
    }
}
