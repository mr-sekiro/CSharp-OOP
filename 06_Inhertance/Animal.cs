using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
