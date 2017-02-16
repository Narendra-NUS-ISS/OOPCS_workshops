using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Workshop
{
    class Customer
    {
        private String name;
        private String address;
        private String passportNumber;
        private DateTime dateOfBirth;

        public Customer(String name, String address, String passportNumber, DateTime dob)
        {
            this.name = name;
            this.address = address;
            this.passportNumber = passportNumber;
            this.dateOfBirth = dob;
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PassportNumber
        {
            get
            {
                return passportNumber;
            }

            set
            {
                passportNumber = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public int Age
        {
            get
            {
                
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
    }
}
