using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Constructor_and_Destructor
{
    internal class clsPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson() //Parameterless
        {
            Id = -1;
            Name = "Empty";
            Age = 0;
        }

        public clsPerson(int id, string name, int age) //Parameterized
        {
            Id = id;
            Name = name;
            Age = age;
        }


        ~clsPerson() // destructor
        {
            Console.WriteLine("Destructor called.");
        }

    }
}
