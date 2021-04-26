using System;

namespace Properti
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            class1.FirstName = "jahin";
            class1.LastName = "hasan";
            var Name=class1.NameMethod();
            Console.WriteLine(Name);
        }
    }
}
