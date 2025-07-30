using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
        }
    }
}
