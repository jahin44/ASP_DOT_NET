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
        public Class1(string FirstName)
        {
            firstName=FirstName;
            Console.WriteLine(firstName);
            
        }
        public Class1()
        {
           
        Console.WriteLine(FirstName + " " + LastName);


        }
        public Class1(string FirstName,String LastName)
        {

            Console.WriteLine(FirstName + " " + LastName);

        }
    }
}
