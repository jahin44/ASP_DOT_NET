using System;

namespace Removed
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "jahin hasan";
            var j=  s.Remove(s.Length - 1, 1);
            Console.WriteLine(j);      
        }
    }
}
