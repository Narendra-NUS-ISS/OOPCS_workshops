using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Workshop
{
    class BankAccount
    {
        private String accountNumber;
        private String accountHolderName;
        private double balance;

        public BankAccount(String accNum, String accHolderName, double bal)
        {
            this.accountNumber = accNum;
            this.accountHolderName = accHolderName;
            this.balance = bal;
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }

           
        }

        public string AccountHolderName
        {
            get
            {
                return accountHolderName;
            }

            set
            {
                accountHolderName = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public bool Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine(" Withdrawl amount is : " + amount);
                return true;
            }
            else
            {
                Console.WriteLine("You dont have sufficient balance to peform withdraw");
                return false;
            }
        }
        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public bool TransferTo(double amount, BankAccount another)
        {
            if (Balance > amount)
            {
                another.Deposit(amount);
                Balance = Balance - amount;
                Console.WriteLine("Successfully Transfered");
                return true;
            }
            else
            {
                Console.WriteLine("You don't have sufficient funds to transfer");
                return false;
            }
        }
        public double Show()
        {
            return Balance;
        }

    }
}
