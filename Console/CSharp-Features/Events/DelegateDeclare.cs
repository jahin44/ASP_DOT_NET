using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class DelegateDeclare
    {
        public delegate void Notify(string address, string message);
        public static event Notify Notification;

    }
}
