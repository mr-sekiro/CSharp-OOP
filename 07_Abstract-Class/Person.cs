using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstract_Class
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void Introduce();

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
