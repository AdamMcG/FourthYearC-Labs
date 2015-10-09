using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingEntSWDevLab;

namespace BankAccountUnitTestSet1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWithdrawAndDeposit()
        {
            BankAccount myAccount = new BankAccount("13-31-23232", "1229292KA", 101);
            myAccount.Deposit(300);
            myAccount.Deposit(300);
            myAccount.Withdraw(800);
            Assert.AreEqual(-100, myAccount.Balance);
        }

        [TestMethod]
        public void TestCollection()
        {
            BankAccount myAccount = new BankAccount("13", "asss");
            myAccount.Deposit(100);
            myAccount.Deposit(300);
            List<double> transaction = new List<double>() { 100, 300, -375 };
            myAccount.Withdraw(375);
            CollectionAssert.AreEqual(transaction, myAccount.Transactions);
            Assert.AreEqual(25, myAccount.Balance);
        }
    }
}
