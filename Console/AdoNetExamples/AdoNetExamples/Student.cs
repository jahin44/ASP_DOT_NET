using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExamples
{
    public class Student :IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
    }
}
