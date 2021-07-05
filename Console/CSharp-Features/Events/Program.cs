using System;

namespace Events
{
    class Program
    {
       
        static void Main(string[] args)
        {
             var instance = new DelegateDeclare();
            DelegateDeclare.Notification += EmailSMS.EmailNotification;
            DelegateDeclare.Notification += EmailSMS.SMSNotification;

            DelegateDeclare.Notification("info@devskill.com", "Hello World");
            

            DelegateDeclare.Notification -= EmailSMS.EmailNotification;

            EmailSMS.Notification("info@devskill.com", "Hello World2");
        }

    }
}
