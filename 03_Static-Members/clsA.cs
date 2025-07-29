using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Static_Members
{
    internal class clsA
    {
        public int x1;
        //x2 is shared for all object because it's on the class level
        public static int x2;


        public int Method1()
        {
            //not static methods can always access the static members
            return x1 + x2;
        }

        public static int Method2()
        {
            //static methods cannot access non-static memebers because there is no object
            //static methods are called at the class level.
            //return clsA.x1 + x2;
            return x2;
        }
    }
}
