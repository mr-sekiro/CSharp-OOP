using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }
}
