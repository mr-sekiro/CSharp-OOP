using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Sealed_Class
{
    internal class Manager : Employee
    {
        //This will produce a compile-time error because the Greet method in Employee is
        //public override void Greet() //sealed and cannot be overridden.
        //{
        //    Console.WriteLine("The manager greets you warmly.");
        //}
    }
}
