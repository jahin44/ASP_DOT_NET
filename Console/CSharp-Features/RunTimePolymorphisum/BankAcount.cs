using System;
using System.Collections.Generic;
using System.Text;

namespace RunTimePolymorphisum
{
    public class BankAcount
    {
        public BankAcount(string name,string id)
        {
            Name = name;
            Id = id;

        }
        public BankAcount()
        {

        }
     
        public string Name { get; set; }
        public string Id { get; set; }
        public int Balance { get;private set; }

        public int AddTK(int amount)
        {

            
          Balance = Balance + amount;
            return Balance;

        }
        public virtual void withdrow(int amount)
        {


            Balance = Balance - amount;
            

        }
        public int CheckBalance()
        {
            return Balance;
        }




    }
}
