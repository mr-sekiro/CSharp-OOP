using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04_Properties
{
    //Static Class
    //A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated.
    //In other words, you cannot use the new operator to create a variable of the class type.

    //Static Properties
    //A static property is similar to a static method.It uses the composite name to be accessed.
    //Static properties use the same get and set tokens as instance properties. They are useful for abstracting global data in programs.
    internal static class Settings
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
    }
}
