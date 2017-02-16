using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Workshop
{
    class BankTest
    {
        public static void Main()
        {
            //Inheritance demo
            BankAccount account1 = new BankAccount("010-565-456", "Naren", 8000);
            BankAccount account2 = new BankAccount("010-568-496", "Jessi", 10000);
            Console.WriteLine(account1.Show());
            Console.WriteLine(account2.Show());
            account1.Deposit(100);
            Console.WriteLine(account1.Show());
            account1.Withdraw(200);
            Console.WriteLine(account1.Show());
            account1.TransferTo(300, account2);
            Console.WriteLine(account1.Show());
            Console.WriteLine(account2.Show());

        }
    }
}
