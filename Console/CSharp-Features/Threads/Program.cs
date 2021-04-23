using System;
using System.Threading;
namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var Thread1 = new Thread(program.PrintNumbers1);
            var Thread2 = new Thread(new ThreadStart(PrintNumbers2));

            Thread1.Start();
            Thread2.Start();
           


        }

        void PrintNumbers1()
        {
            for(var i = 0; i < 100; i ++)
            {
                Console.WriteLine($"Number 1:{i}");
                Thread.Sleep(0);
            }
        }
        static void PrintNumbers2()
        {
            for (var i = 0; i < 100; i ++)
            {
                Console.WriteLine($"Number 2:{i}");
                Thread.Sleep(0);

            }

        }

    }


}
