using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.DependencyAuto
{
    public class SpecialDatabase : IDatabaseUse
    {
        public string GetAge()
        {
            return "SpecialDatabase GetAge";
        }

        public string GetInfo()
        {
            return "SpecialDatabase GetInfo";
        }
    }
}
