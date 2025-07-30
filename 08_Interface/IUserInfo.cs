using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    internal interface IUserInfo
    {
        string Username { get; set; }
        string Role { get; set; }

        void DisplayInfo();
        void ShowMessage();
        string GetInfoString();
    }
}
