using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var DelegateInstance = new DelegateClass();
           
            var text = "my message";
            DelegateInstance.processText(text, DelegateLogic.NewPrintingMethod);


        }
       
       
        


    }
}
