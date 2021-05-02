using System;

namespace RunTimePolymorphisum
{
    class Program
    {
        static void Main(string[] args)
        {
            var genaralAcount = new GenaralAcount("Jahin", "G-101");
            genaralAcount.AddTK(500000);
            //genaralAcount.Interest(genaralAcount.Balance);
            //genaralAcount.withdrow(20000);
            //genaralAcount.Interest(genaralAcount.Balance);
            //genaralAcount.CheckBalance();

            var specialAcount = new SpecialAcount("supty", "S-102");
            specialAcount.AddTK(100000);
            //specialAcount.ServiceCharg(specialAcount.Balance);
            //specialAcount.withdrow(5000000);
            //specialAcount.ServiceCharg(specialAcount.Balance);
            //specialAcount.CheckBalance();

            var Bank = new BankAcount();

            List<BankAcount>account = new List<BankAcount>();



        }
    }
}
