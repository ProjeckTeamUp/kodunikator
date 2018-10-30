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
        private const string serverAdress = "mysql-pol-tronic.ogicom.pl"; // Adres serwera bazy danych
        private const string serverPort = "3306"; // Port serwera

        public MySqlConnection connection = null;

        /// <summary>
        /// Łączy z bazą danych.
        /// </summary>
        public void Connect()
        {
            string connstring = string.Format("Server={0}; Database={1}; UID={1}; Pwd={2}; Port={3}", serverAdress, databaseName, password, serverPort);
            connection = new MySqlConnection(connstring);
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

		public bool Login(string name, string pass)
		{
			string query = string.Format("SELECT Name FROM Konta WHERE Name='{0}' AND Password='{1}'", name, pass);
			List<string> rekordy = new List<string>();
			var cmd = new MySqlCommand(query, connection);
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				rekordy.Add(reader.GetString(0));
			}
			reader.Close();
			if(rekordy.Count != 0)
			{
				if (rekordy[0] == name)
					return true;
			}
			return false;
		}

        /// <summary>
        /// Pobiera liste znajomych z bazy danych.
        /// </summary>
        public List<Friend> LoadFriendList(string username)
        {
            List<Friend> friendList = new List<Friend>();

            // TODO // tworzenie listy znajomych na podstawie bazy danych

            return friendList;
        }
    }
}
