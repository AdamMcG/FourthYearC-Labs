using System;

namespace UnitTestingEntSWDevLab
{
    class Program
    {
        static void Main()
        {
            BankAccount myaccount = new BankAccount("1322", "adsd22", 1000);
            myaccount.Deposit(3000);
            myaccount.Deposit(3000);
            myaccount.Withdraw(6500);
            Console.WriteLine(myaccount.ToString());
            myaccount.Withdraw(1200);
            Console.ReadLine();
        }
    }
}
