﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Models
{
    public class SummaryModel
    {
        public string SummaryText { get; set; }

        public SummaryModel()
        {
            SummaryText = "Hello World";
        }
    }
}
