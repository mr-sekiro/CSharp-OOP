using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Partial_Class
{
    internal partial class MyClass
    {
        public int Age { get; set; }
        public partial void PrintAge();
        public void Method1()
        {
            Console.WriteLine("Method 1 is called.");
        }
    }
}
