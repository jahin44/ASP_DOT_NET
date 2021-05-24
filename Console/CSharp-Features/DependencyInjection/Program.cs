using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            var ManageAccountService = new AccountManageService(new SepcialDatabaseAccess());
            ManageAccountService.CreateAccount("jahinhasan1@gmail.com", "123456");
             

        }
    }
}
