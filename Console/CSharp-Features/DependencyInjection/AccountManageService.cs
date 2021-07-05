using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public class AccountManageService
    {
        private IDatabaseAccess _databaseAccess;
        private IEmailClass _emailSend;


        public AccountManageService(IDatabaseAccess databaseAccess, IEmailClass emailSend)
        {
            _databaseAccess = databaseAccess;
            _emailSend = emailSend;
        }
         

        public void CreateAccount(string email, string pass) 
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pass))
            {


                try
                {
                  
                    _emailSend.UseEmail(email);
                }
                catch
                {
                    _databaseAccess.DeleteAccount(email);
                }
             }
            
        }


    }
}
