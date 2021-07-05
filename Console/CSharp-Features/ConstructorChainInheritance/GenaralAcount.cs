using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorChainInheritance
{
    public class GenaralAcount:BankAcount

    {
     public GenaralAcount(string name,string id) :base(name,id)
        {
            Console.WriteLine("GenaralAcount ");
        } 
     private int interest { set; get; }

     public override void withdrow(int amount)
        {
            if (amount <= Balance)
            {
                base.withdrow(2000); 
            }

        }
     public int Interest(int balance)
        {
            var num= 0;
           
            if (balance/1000!=0)
            {
               num = balance / 1000;
                interest = num;

                return num * 10;
            }
            interest = num;

            return num;

        }


        
    }
}
