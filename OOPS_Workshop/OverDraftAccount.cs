using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Workshop
{

    class OverDraftAccount : BankAccount3
    {
        
        public OverDraftAccount(String accNum, Customer accHolderName, double balance, double interestRate) : base(accNum, accHolderName, balance, interestRate)
        {
            
        }

        public new bool Withdraw(double amount)
        {
                Balance = Balance - amount;
                return true;
        }
        public new double CalculateInterest()
        {
            double interest = 0;
            if (Balance > 0)
            {
                 interest = Balance * InterestRate;
            } else
            {
                interest = Balance * 0.06;
            }
            return interest;
        }
        public new void CreditInterestRate()
        {
            double interest = CalculateInterest();
            if (interest > 0)
            {
                Deposit(interest);
            } else
            {
                Withdraw(Math.Abs(interest));
            }
        }

    }
}
