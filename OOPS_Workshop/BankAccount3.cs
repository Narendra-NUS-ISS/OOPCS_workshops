using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Workshop
{
    class BankAccount3
    {
        private String accountNumber;
        private Customer accountHolderName;
        private double balance;
        private double interestRate;

        public BankAccount3(String accNum, Customer accHolderName, double bal, double intRate)
        {
            this.accountNumber = accNum;
            this.accountHolderName = accHolderName;
            this.balance = bal;
            this.interestRate = intRate;
        }
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                accountNumber = value;
            }
        }

        internal Customer AccountHolderName
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

        public double InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                interestRate = value;
            }
        }

        /** -Accessor/Mutator methods as necessary
Withdraw(double amount)
--cannot withdraw more than balance
Deposit(double amount)
TransferTo(double amount, BankAccount another)
CalculateInterest() -- calculate annual interest
CreditInterest() -- deposit the interest earned
--other support methods as necessary
    **/

        public bool Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance = Balance - amount;
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

        public bool TransferTo(double amount, BankAccount2 another)
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

        public double CalculateInterest()
        {
            double interest = Balance * InterestRate;
            return interest;
        }
        public void CreditInterestRate()
        {
            double interest = CalculateInterest();
            Deposit(interest);
        }
        public double Show()
        {
            return Balance;
        }

    }


}
