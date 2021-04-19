using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExample
{
  
    class Program
    {
       

        static void Main(string[] args)
        {
            var Info = new StudentData();
            
            /*IEnumerable<Student> studentQuery =
                from student in Info.studentInfo
                where student.Scores[0] > 90 
                select student;
            var studentQuery2 =
                from student in Info.studentInfo
                group student by student.Last[1];*/
            var studentQuery4 =
                from student in Info.studentInfo
                group student by student.ID into studentGroup
                orderby studentGroup.Key
                select studentGroup;
             
            /*  foreach (Student student in studentQuery4)
  {
              Console.WriteLine("{0}, {1}", student.ID, student.First);
  }*/
            foreach (var studentGroup in studentQuery4)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine(" {0}, {1}",
                    student.Last, student.First);
                }
            }


        }
    }
}
