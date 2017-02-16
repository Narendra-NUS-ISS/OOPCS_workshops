using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rational;

namespace OOPS_Workshop
{
    class RationalTest
    {
        public static void Main()
        {

            Rationl a = new Rationl(3, 4);
            Rationl b = new Rationl(4, 5);
            Rationl c = a.Add(b);
            Console.WriteLine(c.StrVal());
            c = b.Subtract(a);
            Console.WriteLine(c.StrVal());
        }
    }
}
