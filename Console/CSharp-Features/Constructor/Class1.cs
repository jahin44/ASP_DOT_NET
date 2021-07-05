using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Class1
    {
        public string firstName;
        public string lastName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Class1(string FirstName):this()
         {
            firstName=FirstName;
            Console.WriteLine(firstName);
            
        }
        public Class1()
        {
           
        Console.WriteLine(LastName);


        }
        public Class1(string FirstName,String LastName): this (FirstName)
        {

            Console.WriteLine(FirstName + " " + LastName);

        }


        public void GetFullName()
        {
            firstName = FirstName;
            lastName = LastName;
            Console.WriteLine(firstName + " joy " + lastName);
        }

    }
}
