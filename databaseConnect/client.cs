using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseConnect
{
    internal class client
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }

        public client(string name, string password)
        {
            Name = name;
            Password = password;

        }

        public void insert(SqlConnection connection)
        {
            string insert = $"insert into {nameof(client)} ({nameof(Name)}, {nameof(Password)}) values ('{Name}', '{Password}')";
            using (SqlCommand command = new SqlCommand(insert, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void select(SqlConnection connection, int id)
        {

            string select = $"select * from {nameof(client)} where id = {id}";

            using (SqlCommand command = new SqlCommand(select, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{nameof(Name)}: {reader[0].ToString()}\n" +
                                      $"{nameof(Password)}: {reader[1].ToString()}\n" +
                                      $"{nameof(Password)}: {reader[1].ToString()}");
                }
            }
        }

        public void selectAll(SqlConnection connection)
        {

            string selectAll = $"select * from {nameof(client)}";
            using (SqlCommand command = new SqlCommand(selectAll, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{nameof(Name)}: {reader[0].ToString()}\n" +
                                      $"{nameof(Password)}: {reader[1].ToString()}\n" +
                                      $"-------------------------------------------");
                }
            }
        }



    }
}
