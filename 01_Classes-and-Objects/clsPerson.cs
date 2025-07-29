using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes_and_Objects
{
    internal class clsPerson
    {
        //Feilds: variables to store data
        public string Fname;
        public string Lname;

        //Methods: functions to perform specific tasks
        public string FullName()
        {
            return Fname + " " + Lname;
        }
    }
}
