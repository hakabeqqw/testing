using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.Classes
{
    internal class DataBaseConnection
    {
        // Строка подключения к mysql
        static string ConnectionString = "server=127.0.0.1;port=3306;" +
        "userid=root;password=root;database=shop;sslmode=none";
        // Запихиваю в объект Connection строку с данными для подключения
        static MySqlConnection Connection = new MySqlConnection(ConnectionString);
        static MySqlCommand Command = new MySqlCommand();

        static public void OpenConnection()
        {
            // Открываю соединение
            Connection.Open();
            Command.Connection = Connection;
        }

        static public void CloseConnection()
        {
            //закрываю соединение
            Connection.Close();
        }

        static public DataTable ExecuteDataQuery(string SQL)
        {
            MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, ConnectionString);
            DataTable DataTable = new DataTable();
            Adapter.Fill(DataTable);
            return DataTable;
        }

        static public int ExecuteNonQuery(string SQL)
        {
            Command.CommandText = SQL;
            return Command.ExecuteNonQuery();
        }

    }
}
