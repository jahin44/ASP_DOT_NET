using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDemo.DependenciesBydefult
{
    public class SepcialDatabase : IDatabase
    {
        public string EmailSend()
        {
            return "EmailSend Method";
        }

        public string EmailUse()
        {
            return "EmailUse Method" ;
        }
    }
}
