using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    internal abstract class UserBase : IUserInfo, IContactService
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public abstract void DisplayInfo();

        public void LogOut()
        {
            Console.WriteLine("User has logged out.");
        }

       
        void IUserInfo.ShowMessage()
        {
            Console.WriteLine("Explicit IUserInfo.ShowMessage() implementation.");
        }

        //Explicit IUserInfo.GetInfoString
        string IUserInfo.GetInfoString()
        {
            return $"[User Info] Username: {Username}, Role: {Role}";
        }

        //Implicit IContactService implementations
        public void MakeCall()
        {
            Console.WriteLine("Dialing the number...");
        }

        public void SendEmailMessage(string subject, string content)
        {
            Console.WriteLine($"Email sent: Subject - {subject}, Content - {content}");
        }

        public void SendTextMessage(string subject, string content)
        {
            Console.WriteLine($"SMS sent: Subject - {subject}, Content - {content}");
        }
        void IContactService.SendFaxMessage(string subject, string content)
        {
            Console.WriteLine($"Fax sent [Explicit]: Subject - {subject}, Content - {content}");
        }
    }
}
