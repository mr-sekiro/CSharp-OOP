using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Sealed_Class
{
    internal class Employee : Person
    {
        public sealed override void Greet()
        {
            Console.WriteLine("The employee greets you.");
        }
    }
}
