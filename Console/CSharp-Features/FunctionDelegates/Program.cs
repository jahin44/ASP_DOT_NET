using System;

namespace FunctionDelegates
{
    class Program
    {
        static void Test(Func<string,string,string> a)
        {
           
           var b= a( 2,2);            
        }
        static void Main(string[] args)
        {
            int a, b;
        
            Test(DoPrint);
        }
        public static int DoPrint(int x,int y)
        {
             Console.WriteLine($"...{a}..{b}...");

            return a+b;
        }

    }
}
