using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child : Parent
    {
        public Child():base("Vishwas Verma")
        {
            Console.WriteLine("Child Class Constructor Got Executed");
        }
    }
}
