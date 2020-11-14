using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class QueryExecuter
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["LibratorsEntitiesConnectionString"].ConnectionString;
        public static List<string[]> getQueryAsList(string queryString) {
            Console.WriteLine($"Executing query: {queryString} on Database: {connectionString}");
            List<string[]> list = new List<string[]>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                command.CommandTimeout = 15;
                command.CommandType = CommandType.Text;
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    string[] array = new string[reader.FieldCount];
                    for(int i = 0; i < array.Length; i++)
                    {
                        array[i] = reader[i].ToString();
                    }
                    list.Add(array);
                }
                return list;
            }
        }
        public static void insertQuery(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandText = queryString;
                command.CommandTimeout = 15;
                command.CommandType = CommandType.Text;
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                Properties.Settings.Default.Save();
            }
        }
    }
}
