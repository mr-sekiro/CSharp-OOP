using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    internal class AdminUser : UserBase
    {
        public int AdminLevel { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Admin User: {Username}, Role: {Role}, Level: {AdminLevel}");
        }
    }
}
