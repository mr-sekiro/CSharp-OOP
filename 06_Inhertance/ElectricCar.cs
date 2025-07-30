using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class ElectricCar : Car
    {
        public int BatteryLevel { get; set; }

        public void Charge()
        {
            Console.WriteLine($"{Brand} {Model} is charging. Battery at {BatteryLevel}%.");
        }
    }
}
