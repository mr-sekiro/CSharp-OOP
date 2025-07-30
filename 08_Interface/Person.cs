using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    internal abstract class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public abstract void Introduce();

        public void Print()
        {
            Console.WriteLine("Hi I'm the print method");
        }

        public string To_String()
        {
            return "Hi this is the complete string....";

        }
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }

        public void SendEmail()
        {
            Console.WriteLine("Email Sent :-)");
        }

    }
}
