using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class Vehicle
    {
        public string Brand { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }
    }
}
