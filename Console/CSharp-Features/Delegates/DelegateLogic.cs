﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class DelegateLogic
    {
        public static void NewPrintingMethod(string textToPrint)
        {

            Console.WriteLine($".......{textToPrint}.....");


        }

        public static void PrintingMethod(string textToPrint)
        {
            Console.WriteLine($".....{textToPrint}.....");
        }


    }
}
