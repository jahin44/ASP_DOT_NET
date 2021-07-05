using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorChainInheritance
{
   public class SpecialAcount:BankAcount
    {
        public SpecialAcount(string name,string id ):base(name,id)
        {
            Console.WriteLine("Special Account");

        }
        private int serviceCharg { get; set; }
        public int ServiceCharg(int balance)
        {
            var num = 0;
        if (balance / 1000 != 0)
            {
                num = balance / 1000;
                serviceCharg = num;

                return num * 15;
            }

            serviceCharg = num;

            return num;
        }

    }
}
