using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server = DESKTOP-9UKEJ28\\SQLEXPRESS; Database = CSharpData; User Id = admin; Password = 123456;";
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }

            using SqlCommand command = new SqlCommand();
            var sql = "UPDATE Student SET Name ='jahin', weight = '81' WHERE Id = 4 ";

            command.Connection = connection;

          //  WriteOperation(sql, connection);
            var sql2 = "select * from student";
            var students = ReadOperation(sql2, connection);
            foreach(var student in students)
            {
                Console.WriteLine($"Id ={student.Id},Name= {student.Name},Weight ={student.Weight}");
            }
            
            Console.WriteLine("insert completed");
        }
        static void WriteOperation(string sql, SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }

            using SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = connection;

            command.ExecuteNonQuery();
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Weight { get; set; }
             
        }

        static IList<Student> ReadOperation (string sql, SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            using SqlCommand command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read())
            {
                var student = new Student();
                student.Id = (int)reader["Id"];
                student.Name = (string)reader["Name"];
                student.Weight = (decimal)reader["Weight"];
                students.Add(student);
            }
            return students;
        }



    }
}
