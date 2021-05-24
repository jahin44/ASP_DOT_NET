using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class DatabaseAccess : IDatabaseAccess
    {
        public void DeleteAccount(string email)
        {
            Console.WriteLine("Account is Deleted");

        }

        public void SeveUserID(string email, string pass)
        {
            
        }
    }
}
