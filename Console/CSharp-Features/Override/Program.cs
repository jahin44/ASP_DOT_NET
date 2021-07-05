using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            var genaralAcount = new GenaralAcount();
            //genaralAcount.Id = "G-101";
            //genaralAcount.Name = "jahin";
            //genaralAcount.AddTK(500000);
            //genaralAcount.Interest(genaralAcount.Balance);
            //genaralAcount.withdrow(20000);
            //genaralAcount.Interest(genaralAcount.Balance);
            //genaralAcount.CheckBalance();

            var specialAcount = new SpecialAcount();
            //specialAcount.Id = "S-102";
            //specialAcount.Name = "Supty";
            //specialAcount.AddTK(100000);
            //specialAcount.ServiceCharg(specialAcount.Balance);
            //specialAcount.withdrow(5000000);
            //specialAcount.ServiceCharg(specialAcount.Balance);
            //specialAcount.CheckBalance();
        }
    }
}
