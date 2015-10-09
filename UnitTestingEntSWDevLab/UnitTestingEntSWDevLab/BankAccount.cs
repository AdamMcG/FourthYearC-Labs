using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingEntSWDevLab
{
    public class BankAccount
    {
        private List<double> TransactionHistory;
        public List<double> Transactions
        {
            get { return TransactionHistory; }
        }
        private string sortCode;

        public string SortCode => sortCode;

        private string accountNumber;

        public string AccountNumber => accountNumber;

        private double overdraftLimit;

        public double OverdraftLimit => overdraftLimit;

        private double balance;

        public double Balance => balance;

        public BankAccount(string sort, string account, double overdraft)
        {
            this.sortCode = sort;
            this.accountNumber = account;
            this.overdraftLimit = overdraft;
            this.balance = 0;
            TransactionHistory = new List<double>();
        }

        public BankAccount(string sort, string account)
        {
            this.sortCode = sort;
            this.accountNumber = account;
            this.overdraftLimit = 0;
            this.balance = 0;
            TransactionHistory = new List<double>();
        }

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
            TransactionHistory.Add(depositAmount);
        }

        public void Withdraw(double withdrawAmount)
        {
            if ((balance + overdraftLimit) - withdrawAmount >= 0)
            {
                balance -= withdrawAmount;
                TransactionHistory.Add(-withdrawAmount);
            }
            else
            {
                throw new ArgumentException("You cannot cover this transaction");
            }
        }

        public override string ToString()
        {
            var a = String.Empty;
            for (var i = 0; i < TransactionHistory.Count; i++)
            {
                a += "\nTransaction" + (i + 1) + ": " + TransactionHistory.ElementAt(i);
            }
            return "Account: + \n" + "\nSort Code: " + SortCode + "\nAccount Number: " + AccountNumber
                   + "\nCurrent OverDraft: " + OverdraftLimit + "\nCurrent Balance: " + Balance + "\n\nTransactions: " + a;
        }
    }
}
