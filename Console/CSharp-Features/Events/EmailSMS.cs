using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class EmailSMS
    {
        public static void EmailNotification(string address, string message)
        {
            Console.WriteLine($"sending Email to {address} with message {message}");
        }
        public static void SMSNotification(string mobileNumber, string message)
        {
            Console.WriteLine($"Sending SMS to {mobileNumber} with message {message}");
        }
    }
}
