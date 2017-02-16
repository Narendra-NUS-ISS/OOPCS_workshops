using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Workshop
{
    class CurrentAccount : BankAccount3
    {
        public CurrentAccount(String accNum, Customer accHolderName, double balance, double interestRate) : base(accNum, accHolderName, balance, interestRate)
        {

        }
    }
}
