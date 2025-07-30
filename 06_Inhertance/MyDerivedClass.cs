using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class MyDerivedClass : MyBaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived class implementation using override");
        }


        public new void MyOtherMethod()
        {
            Console.WriteLine("Derived class implementation of MyOtherMethod using new");
        }
    }
}
