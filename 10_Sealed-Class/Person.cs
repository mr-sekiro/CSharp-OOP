using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Sealed_Class
{
    internal class Person
    {
        public virtual void Greet()
        {
            Console.WriteLine("The person says hello.");
        }
    }
}
