using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kodunikator
{
	/// <summary>
	/// Klasa obsługuje połączenie między aplikacją, a bazą danych.
	/// </summary>
	public class DBConnection
	{
		public DBConnection() { }

		private const string databaseName = "db100007984"; // Nazwa bazy danych
		private const string password = "1qsc@WDVawix"; // Hasło do bazy danych
		private const string serverAdress = "mysql-pol-tronic.ogicom.pl"; // Adres serwera bazy danych
		private const string serverPort = "3306"; // Port serwera
		private bool connected = false;

		public MySqlConnection connection = null;

		/// <summary>
		/// Łączy z bazą danych.
		/// </summary>
		public void Connect()
		{
			string connstring = string.Format("Server={0}; Database={1}; UID={1}; Pwd={2}; Port={3}", serverAdress, databaseName, password, serverPort);
			connection = new MySqlConnection(connstring);
			connected = true;
			connection.Open();
		}

		public void Close()
		{
			connected = false;
			connection.Close();
		}

		public bool isConnected() { return connected; }

		/// <summary>
		/// Zwraca dla czego nie powiodła się rejestracja albo pustą pustą linijkę przy udanej rejestracji.
		/// </summary>
		public async void RegisterUserAsync(Label warningFeild, string name, string pass, string fb_mail, string fb_pass)
		{
			string checkQuery = string.Format("SELECT Name FROM Konta WHERE Name='{0}'", name);
			var cmd4Check = new MySqlCommand(checkQuery, connection);
			List<string> tmp = new List<string>();
			var reader = cmd4Check.ExecuteReader();
			while (reader.Read())
			{
				tmp.Add(reader.GetString(0));
			}
			reader.Close();
			if(tmp.Count != 0)
			{
				warningFeild.Text = "User with this username already exists";
				warningFeild.Visible = true;
				Log.NewLog("User with this username already exists");
			}
			if(!await Facebook.LogIn(fb_mail, fb_pass))
			{
				warningFeild.Text = "Facebook verification fail.";
				warningFeild.Visible = true;
				Log.NewLog("Facebook verification fail.");
			}
			string query = string.Format("INSERT INTO Konta (Name, Password, FB_ID, Friends, FB_mail, FB_password) VALUES ('{0}', '{1}', NULL, NULL, '{2}', '{3}')", name, Encrypter.HashThePassword(pass), fb_mail, Encrypter.Encrypt(fb_pass, pass));
			var cmd = new MySqlCommand(query, connection);
			if (cmd.ExecuteNonQuery() != 0)
			{
				Facebook.LogOut();
				Program.RegisterSuccess();
			}

			warningFeild.Text = "Unknown registration error.";
			warningFeild.Visible = true;
			Log.NewLog("Unknown registration error.");
		}

		public bool Login(string name, string pass)
		{
			string query = string.Format("SELECT FB_mail, FB_password FROM Konta WHERE Name='{0}' AND Password='{1}'", name, Encrypter.HashThePassword(pass));
			var cmd = new MySqlCommand(query, connection);
			var reader = cmd.ExecuteReader();
			string fbMail = null, fbPass = null;
			while (reader.Read())
			{
				fbMail = reader.GetString("FB_mail");
				fbPass = reader.GetString("FB_password");
			}
			reader.Close();
			if (fbMail != null && fbPass != null)
			{
				//save facebook password or log in
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
