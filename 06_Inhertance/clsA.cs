using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class clsA
    {
        public virtual void Print() //virtual - allows the method to be overridden by the derived class

        {
            Console.WriteLine("Hi, I'm the print method from the base class A");
        }
    }
}
