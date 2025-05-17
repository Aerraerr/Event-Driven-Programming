using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EDP_GymwithGUI
{
    public static class dbConnection
    {
        // Your connection string here
        private static readonly string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";

        // Method to get a new MySqlConnection using your connection string
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}