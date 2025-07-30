using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Constructor_and_Destructor
{
    /*
     Private Constructor
     We can create a private constructor using the private access specifier. This is known as a private constructor in C#.
     Once the constructor is declared private, we cannot create objects of the class in other classes.
    */

    //(Static Class instead of Private Constructor)
    internal class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }

        //this is a private constructor to prevent creating object from this class
        private Settings()
        {

        }

        /*
        We cannot call a static constructor directly. However, the static constructor gets called automatically.
        The static constructor is called only once during the execution of the program.
        That's why when we call the constructor again, only the regular constructor is called.
        Note: We can have only one static constructor in a class. It cannot have any parameters or access modifiers.
        */

        //static Settings()
        //{
        //    ProjectPath = @"C:\MyProjects\";
        //}

    }
}
