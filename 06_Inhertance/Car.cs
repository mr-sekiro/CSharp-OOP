using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class Car : Vehicle
    {
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving.");
        }
    }
}
