using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExamples
{
    public class MyORM<T> where T : IData
    {
        private SqlConnection _sqlConnection;

        public MyORM(SqlConnection connection)
        {
            _sqlConnection = connection;
        }

        public MyORM(string connectionString)
            : this(new SqlConnection(connectionString))
        {

        }


        //UPDATE 
        public void Update(T item)
        {
            var sql = new StringBuilder("UPDATE ");
            var type = item.GetType();
            var properties = type.GetProperties();

            sql.Append(type.Name);
            sql.Append(" SET");
            foreach (var property in properties)
            {
                if (property != properties[0])
                {
                    sql.Append(' ').Append(property.Name).Append('=').Append('@').Append(property.Name).Append(' ').Append(',');
                }
            }
            sql.Remove(sql.Length - 1, 1);

            sql.Append("WHERE ");

            foreach (var property in properties)
            {
                if (property == properties[0])
                {
                    sql.Append(property.Name).Append('=').Append('@').Append(property.Name);
                }
            }

            sql.Append(';');
            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlConnection);
            foreach (var property in properties)
            {                 
                command.Parameters.AddWithValue(property.Name, property.GetValue(item));              
            }

            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            command.Connection = _sqlConnection;
            command.ExecuteNonQuery();
            Console.WriteLine("Update Successfull");

        }


          //INSERT 



        public void Insert(T item)
        {
            var sql = new StringBuilder("Insert into ");
            var type = item.GetType();
            var properties = type.GetProperties();

            sql.Append(type.Name);
            sql.Append('(');
            foreach (var property in properties)
            {
                if (property != properties[0] )
                {
                    sql.Append(' ').Append(property.Name).Append(',');
                }
            }
            sql.Remove(sql.Length - 1, 1);

            sql.Append(") values(");

            foreach (var property in properties)
            {
                if (property != properties[0])
                {
                    sql.Append('@').Append(property.Name).Append(',');
                }
            }
            sql.Remove(sql.Length - 1, 1);
            sql.Append(")");

            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlConnection);
            foreach (var property in properties)
            {                 
               command.Parameters.AddWithValue(property.Name, property.GetValue(item));                                     
            }

            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            command.Connection = _sqlConnection;
            command.ExecuteNonQuery();
            Console.WriteLine("Insert Successfull");
        }



        //Delete


        public void Delete(T item)
        {
            Delete(item.Id);
        }

        public void Delete(int Id)
        {
            var type = typeof(T);
            var sql = new StringBuilder("DELETE FROM ");
            sql.Append(type.Name).Append(" WHERE").Append(" Id").Append('=').Append(Id).Append(';');
            var query = sql.ToString();

            var command = new SqlCommand(query, _sqlConnection);
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            command.Connection = _sqlConnection;
            command.ExecuteNonQuery();
            Console.WriteLine("Delete Successfull");
        }



        //Get All
        public IList<T> GetAll()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            var type = typeof(T);
            var properties = type.GetProperties();
            var sql = "SELECT * FROM " + type.Name;

            using SqlCommand command = new SqlCommand(sql, _sqlConnection);
            var reader = command.ExecuteReader();
            
            List<T> TableDatas = new List<T>();
            var t = typeof(T);
            while (reader.Read())
            {
                T obj = (T)Activator.CreateInstance(t);
                t.GetProperties().ToList().ForEach(property =>
                {
                    property.SetValue(obj, reader[property.Name]);
                } );
                TableDatas.Add(obj);                
            }
            return TableDatas;
        }


        //GetBy ID


        public T GetById(int id)
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            var type = typeof(T);
            var properties = type.GetProperties();
            var sql = "SELECT * FROM " + type.Name+" Where Id ="+id+(" ;");

            using SqlCommand command = new SqlCommand(sql, _sqlConnection);
            var reader = command.ExecuteReader();

            
            var t = typeof(T);
            
                T obj = (T)Activator.CreateInstance(t);
            while (reader.Read())
            {
                t.GetProperties().ToList().ForEach(property =>
                {
                    property.SetValue(obj, reader[property.Name]);
                } );
            }

            return obj;

        }
    }

}
