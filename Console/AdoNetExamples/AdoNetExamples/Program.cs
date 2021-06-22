using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdoNetExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server = DESKTOP-9UKEJ28\\SQLEXPRESS; Database = CSharpData; User Id = admin; Password = 123456;";
 
            Student student = new Student();
            MyORM<Student> ORM = new MyORM<Student>(connection.ConnectionString);
            student.Id = 1002;
            student.Name = "Hasan";
            student.Weight = 85;

            ORM.Insert(student);

            ORM.Update(student);

            ORM.Delete(student);


            //get all data

            var TableData = ORM.GetAll();
            foreach (var data in TableData)
            {
                Console.WriteLine($"Id = {data.Id}, Name = {data.Name}, Weight = {data.Weight}");
            }


            //Get By ID

            var IdData = ORM.GetById(1005);
            Console.WriteLine($"Id = {IdData.Id}, Name = {IdData.Name}, Weight = {IdData.Weight}");

            Console.WriteLine("Successfull");
        }
         
    }
    }
