using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionAndAction
{
    public class ActionDelegatesClass
    {
        public static void ProcessText(string text, Action<string> Perform)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                Perform(text);
            }
        }
    }
}
