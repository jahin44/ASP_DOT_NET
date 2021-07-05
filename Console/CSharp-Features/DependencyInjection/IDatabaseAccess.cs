using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public interface IDatabaseAccess
    {
        public void DeleteAccount(string email);
        public void SeveUserID(string email, string pass);
        
    }
}
