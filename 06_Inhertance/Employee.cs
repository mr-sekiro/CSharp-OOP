using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class Employee : Person
    {
        public string Company { get; set; }
        public decimal Salary { get; set; }


        public void Work()
        {
            Console.WriteLine($"I work at {Company} and earn {Salary:C} per year.");
        }
    }
}
