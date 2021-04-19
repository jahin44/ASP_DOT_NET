using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
   public class DelegateClass
    {
        public delegate void Perform(string text);

        public void processText(string text, Perform perform)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                perform(text);
            }
        }

    }
}
