using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kodunikator
{
    /// <summary>
    /// Klasa obsługuje połączenie między aplikacją, a bazą danych.
    /// </summary>
    class DBConnection
    {
        public DBConnection() { }

        private const string databaseName = "db100007984"; // Nazwa bazy danych
        private const string password = "1qsc@WDVawix"; // Hasło do bazy danych

        public MySqlConnection connection = null;

        /// <summary>
        // Łączy z bazą danych.
        /// </summary>
        public void Connect()
        {
            string connstring = string.Format("Server=mysql-pol-tronic.ogicom.pl; Database={0}; UID={0}; Pwd={1}; Port=3306", databaseName, password);
            connection = new MySqlConnection(connstring);
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
