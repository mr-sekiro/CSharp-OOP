using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstract_Class
{
    internal class Employee : Person
    {
        public int EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
        }
    }
}
