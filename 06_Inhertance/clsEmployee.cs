using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inhertance
{
    internal class clsEmployee : clsPerson //Drevied Class
    {


        public float Salary { get; set; }
        public string DepartmentName { get; set; }

        //public clsEmployee(int ID, string FirstName, string LastName, string Title,
        //           float Salary, string DepartmentName) : base(ID, FirstName, LastName, Title)
        //{
        //    this.Salary = Salary;
        //    this.DepartmentName = DepartmentName;

        //}

        public void IncreaseSalaryBy(float Amount)
        {
            Salary += Amount;
        }


    }
}
