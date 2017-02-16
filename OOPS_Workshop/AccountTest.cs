using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Workshop
{
    class AccountTest
    {
        public static void Main()
        {

            Customer x = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer y = new Customer("Kim Lee Keng", "2, Rich View", "XXX5F", new DateTime(1993, 4, 25));
            Customer z = new Customer("Kim Lin Loo", "2, East View", "XXX7F", new DateTime(1993, 4, 25));
            Console.WriteLine(" ---------------------- Current Account  ----------------------");
            SavingsAccount savings = new SavingsAccount("111-564-789",x, 10000, 0.01);
            savings.Withdraw(150);
            Console.WriteLine(" Savings Balance " + savings.Show());
            savings.Deposit(100);
            Console.WriteLine(" Savings Balance after deposit of 100 " + savings.Show());
            Console.WriteLine(" Interest " + savings.CalculateInterest());
            savings.CreditInterestRate();
            Console.WriteLine(" Savings Balance after interest credit " + savings.Show());

            Console.WriteLine(" ---------------------- Current Account  ----------------------");
            CurrentAccount current = new CurrentAccount("111-584-749", y, 8000, 0.0025);
            current.Withdraw(150);
            Console.WriteLine(" current Balance " + current.Show());
            current.Deposit(100);
            Console.WriteLine(" current Balance after deposit " + current.Show());
            Console.WriteLine(" Interest " + current.CalculateInterest());
            current.CreditInterestRate();
            Console.WriteLine(" current Balance after interest credit " + current.Show());

            Console.WriteLine(" ---------------------- overdraft  ----------------------");
            OverDraftAccount overdraft = new OverDraftAccount("123-555-749", z, -9000, 0.0025);
            Console.WriteLine(" overdraft Balance " + overdraft.Show());
            overdraft.Withdraw(400);
            Console.WriteLine(" overdraft Balance after deposit " + overdraft.Show());
            overdraft.Deposit(100);
            Console.WriteLine(" Interest " + overdraft.CalculateInterest());
            overdraft.CreditInterestRate();
            Console.WriteLine(" overdraft Balance after interest credit" + overdraft.Show());
        }
    }
}
