using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    internal interface IContactService
    {
        void MakeCall();
        void SendEmailMessage(string subject, string content);
        void SendTextMessage(string subject, string content);
        void SendFaxMessage(string subject, string content);
    }
}
