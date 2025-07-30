using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Properties
{
    internal class clsEmployee
    {
        // Private fields
        private int _ID;
        private string _Name = string.Empty;


        //ID Property Declaration
        public int ID //Read Only
        {
            //Get is use for Reading field
            get
            {
                return _ID;
            }
        }

        //Name Property Declaration
        public string Name
        {

            get
            {
                return _Name;
            }

            set //Set is use for writing field
            {
                _Name = value;
            }

        }

        public double Salary { get; set; } //Auto-Implemented Property
        public string Password { private get; set; } // Write Only (accessible only inside the class)

    }
}
