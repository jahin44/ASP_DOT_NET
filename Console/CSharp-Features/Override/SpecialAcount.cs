using System;
using System.Collections.Generic;
using System.Text;

namespace Override
{
   public class SpecialAcount:BankAcount
    {
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
