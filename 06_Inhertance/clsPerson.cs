using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class clsPerson //Base Class
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        //public clsPerson(int ID, string FirstName, string LastName, string Title)
        //{
        //    this.ID = ID;
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.Title = Title;
        //}

        public string FullName //Read only Property
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
    }
}
