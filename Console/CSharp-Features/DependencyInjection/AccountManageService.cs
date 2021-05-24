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

        public AccountManageService(IDatabaseAccess databaseAccess)
        {
            _databaseAccess = databaseAccess;
        }
         

        public void CreateAccount(string email, string pass) 
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pass))
            {


                try
                {
                    var emailService = new EmailService();
                    emailService.UseEmail(email);
                }
                catch
                {
                    _databaseAccess.DeleteAccount(email);
                }
             }
            
        }


    }
}
