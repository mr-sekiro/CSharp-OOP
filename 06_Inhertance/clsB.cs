using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class clsB : clsA
    {
        public override void Print() ///override - indicates the method is overriding the method from the base class
        {
            Console.WriteLine("Hi, I'm the print method from the derived class B");
            base.Print(); //base keyword is used to call the Print method in the base class.
        }
    }
}
