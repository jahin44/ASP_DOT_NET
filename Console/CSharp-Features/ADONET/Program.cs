using System;
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
            var sql = "insert into Student (Name, Weight) values('Supty', 70)";
            command.Connection = connection;

            WriteOperation(sql, connection);
            
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



    }
}
