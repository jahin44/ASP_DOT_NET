using System;

namespace Events
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // var instance = new DelegateDeclare();
            DelegateDeclare.Notification += EmailSMS.EmailNotification;
            DelegateDeclare.Notification += EmailSMS.SMSNotification;

            EmailSMS.EmailNotification("info@devskill.com", "Hello World");
            EmailSMS.EmailNotification("info@devskill.com", "Hello World");

            DelegateDeclare.Notification -= EmailSMS.EmailNotification;

            EmailSMS.SMSNotification("info@devskill.com", "Hello World2");
        }

    }
}
