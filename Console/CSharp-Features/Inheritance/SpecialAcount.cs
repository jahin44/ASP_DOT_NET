using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class SpecialAcount:BankAcount
    {
        public int ServiceCharg()
        {
            var num = 0;
            var bankAcount = new BankAcount();
            var balance = bankAcount.Balance;
            if (balance % 1000 != 0)
            {
                num = balance % 1000;
                return num * 15;
            }


            return num;
        }

    }
}
