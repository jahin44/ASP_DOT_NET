using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
           // var class1 = new Class1("jahin");

            var class2 = new Class1("Israt", "supty");
            //var class3 = new Class1();
            //    class3.FirstName = "Moon";
            //  class3.LastName = "Hasan";
            class2.FirstName = "Jahin";
            class2.LastName = "Chowdhury";
            class2.GetFullName();
        }
    }
}
