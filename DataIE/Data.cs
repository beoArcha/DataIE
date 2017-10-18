using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DataIE
{
    public class DBConnection
    {
        private DBConnection()
        {
        }        

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        public string Server { get; set; }
        public string Login { get; set; }
        public string Port { get; set; }
        private string password;
        public string Password
        {
            set { password = value; }
        }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection instance = null;
        public static DBConnection Instance()
        {
            if (instance == null)
                instance = new DBConnection();
            return instance;
        }

        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(Server)|| String.IsNullOrEmpty(databaseName) || String.IsNullOrEmpty(Port) || String.IsNullOrEmpty(Login))
                    result = false;
                string connstring = string.Format("Server={0}; database={1}; pwd={2}; UID={3}; password={4}", Server, databaseName, Port, Login, password);
                connection = new MySqlConnection(connstring);
                connection.Open();
                result = true;
            }
            return result;
        }

        public void Close()
        {
            connection.Close();
            connection = null;
        }
    }
}
