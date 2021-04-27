using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var genaralAcount = new GenaralAcount();
            genaralAcount.Id = "G-101";
            genaralAcount.Name = "jahin";
            genaralAcount.AddTK(500000);
            genaralAcount.Interest();
            genaralAcount.widraw(20000);
            genaralAcount.Interest();
            genaralAcount.CheckBalance();

            var specialAcount = new SpecialAcount();
            specialAcount.Id = "S-102";
            specialAcount.Name = "Supty";
            specialAcount.AddTK(100000);
            specialAcount.ServiceCharg();
            specialAcount.widraw(30000);
            specialAcount.ServiceCharg();
            specialAcount.CheckBalance();

        
        }
    }
}
