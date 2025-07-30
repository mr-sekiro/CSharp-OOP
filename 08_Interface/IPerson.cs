using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    internal interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        void Introduce();
        //    void Introduce() //default Implementation after C# 8.0
        //    {
        //        Console.WriteLine("This is the default Implementation.");
        //    } //void Intoduce() => Console.WriteLine("This is the default Implementation.");

        void Print();
        string To_String();
    }
}
