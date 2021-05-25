using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDemo.DependenciesBydefult
{
    public class SimpleDatabase : IDatabase
    {
        private ISimpleClassDependency _simpleClassDependency;
        SimpleDatabase(ISimpleClassDependency simpleDatabase)
        {
            _simpleClassDependency = simpleDatabase;

        }
        public string EmailSend()
        {
            return "EmailSend SimpleDatabase ";
        }

        public string EmailUse()
        {
            return "EmailUse SimpleDatabase";
        }
    }
}
