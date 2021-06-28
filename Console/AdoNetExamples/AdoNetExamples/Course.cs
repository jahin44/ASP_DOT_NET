using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExamples
{
    public class Course : IData
    {
        public int Id { get; set; }
        public int StudentId {get;set;}
        public string CName { get; set; }
        public Student Cstudent { get; set; }
        public List<Student>students { get; set; }
    
    }
}
