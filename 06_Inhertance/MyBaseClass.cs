using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class MyBaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base class implementation");
        }


        public virtual void MyOtherMethod()
        {
            Console.WriteLine("Base class implementation of MyOtherMethod");
        }
    }

}
