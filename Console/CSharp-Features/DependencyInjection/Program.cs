using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            var ManageAccountService = new AccountManageService(new DatabaseAccess(),new EmailService());
            ManageAccountService.CreateAccount("jahinhasan1@gmail.com", "1234");
             

        }
    }
}
