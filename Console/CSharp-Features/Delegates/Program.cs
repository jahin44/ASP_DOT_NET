using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var DelegateInstance = new DelegateClass();
           
            var text = "my message";
            DelegateInstance.processText(text, NewPrintingMethod);


        }
        public static void NewPrintingMethod(string textToPrint)
        {

            Console.WriteLine($".......{textToPrint}.....");


        }
        public static void printingMethod(string textToPrint)
        {
            Console.WriteLine($".....{textToPrint}.....");
        }
        


    }
}
