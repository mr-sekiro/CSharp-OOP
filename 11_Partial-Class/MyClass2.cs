using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Partial_Class
{
    internal partial class MyClass
    {
        public partial void PrintAge()
        {
            Console.WriteLine("My Age is {0}", Age);
        }
        public void Method2()
        {
            Console.WriteLine("Method 2 is called.");
        }
    }
}
