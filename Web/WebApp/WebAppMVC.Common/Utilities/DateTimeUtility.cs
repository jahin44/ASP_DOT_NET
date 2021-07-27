using WebAppMVC.Common.Utilities;
using System;

namespace WebAppMVC.Common.Utilities
{
    public class DateTimeUtility : IDateTimeUtility
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
