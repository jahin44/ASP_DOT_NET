using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.DependencyAuto
{
    public class SimpleDatabase : IDatabaseUse
    {
        public string GetAge()
        {
            return "SimpleDatabase Get Age";

        }

        public string GetInfo()
        {
            return "SimpleDatabase GetInfo";
        }
    }
}
