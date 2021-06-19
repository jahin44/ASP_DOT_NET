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
            var sql = "insert into student (name, weight) values('jalaluddin', 23)";
            //WriteOperation(sql, connection);

            Student student = new Student();
            MyORM<Student> ORM = new MyORM<Student>(connection.ConnectionString);
            student.Name ="Supty" ;
            student.Weight = 75;
            

            ORM.Insert(student);





            var sql2 = "select * from student";
           // var students = ReadOperation(sql2, connection);

           /* foreach(var student in students)
            {
                Console.WriteLine($"Id = {student.Id}, Name = {student.Name}, Weight = {student.Weight}");
            }

            Console.WriteLine("Complete");*/
        }

        /*static void WriteOperation(string sql, SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            using SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = connection;

            command.ExecuteNonQuery();
        }

       

        static IList<Student> ReadOperation(string sql, SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            using SqlCommand command = new SqlCommand(sql, connection);

            var reader = command.ExecuteReader();

            var students = new List<Student>();
            while(reader.Read())
            {
                var student = new Student();
                student.Id = (int)reader["Id"];
                student.Name = (string)reader["Name"];
                student.Weight = (decimal)reader["Weight"];

                students.Add(student);
            }

            return students;
        }*/
    }
}
