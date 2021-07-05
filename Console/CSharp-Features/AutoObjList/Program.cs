using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AutoObjList
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var StudentType = typeof(Student);
            for (int i = 0; i <= 10; i++)
            {
                Student obj = (Student)Activator.CreateInstance(StudentType);
                StudentType.GetProperties().ToList().ForEach(property =>
                {
                    property.PropertyType. ;
                });
            }
            List<Student> students = new List<Student>()
            {


            };



            DateTime localDate = DateTime.Now;
            Console.WriteLine("time : {0}", 
                           localDate);
        }
    }
}
