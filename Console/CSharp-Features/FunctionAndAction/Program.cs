using System;

namespace FunctionAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "my message";
            ActionDelegatesClass.ProcessText(text, ActionLogic.NewprintingMethod);
        }
      
       
    }
}
