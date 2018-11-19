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
		/// Zwraca dlaczego nie powiodła się rejestracja albo pustą pustą linijkę przy udanej rejestracji.
		/// </summary>
		public async void RegisterUserAsync(RegisterForm registerForm, string name, string pass, string fb_mail, string fb_pass)
		{
			string checkQueryName = string.Format("SELECT Name FROM Konta WHERE Name='{0}'", name);
			string checkQueryFb = string.Format("SELECT Name FROM Konta WHERE FB_mail='{0}'", fb_mail);
			var cmd4CheckName = new MySqlCommand(checkQueryName, connection);
			cmd4CheckName.CommandTimeout = 2;
			var cmd4CheckFb = new MySqlCommand(checkQueryFb, connection);
			cmd4CheckFb.CommandTimeout = 2;
			List<string> tmp = new List<string>();
			var readerName = cmd4CheckName.ExecuteReader();
			while (readerName.Read())
			{
				tmp.Add(readerName.GetString(0));
			}
			readerName.Close();
			if(tmp.Count != 0)
			{
				registerForm.ErrorMessage("User with this username already exists.");
				return;
			}
			tmp.Clear();
			var readerFb = cmd4CheckFb.ExecuteReader();
			while (readerFb.Read())
			{
				tmp.Add(readerFb.GetString(0));
			}
			readerFb.Close();
			if(tmp.Count != 0)
			{
				registerForm.ErrorMessage("User with this Facebook account already exists.");
				return;
			}
			if (!await Facebook.LogIn(fb_mail, fb_pass))
			{
				registerForm.ErrorMessage("Facebook verification fail.");
				return;
			}
			string query = string.Format("INSERT INTO Konta (Name, Password, FB_ID, Friends, FB_mail, FB_password) VALUES ('{0}', '{1}', '{4}', '', '{2}', '{3}')", name, Encrypter.HashThePassword(pass), fb_mail, Encrypter.Encrypt(fb_pass, pass), Facebook.GetFacebookID());
			var cmd = new MySqlCommand(query, connection);
			if (cmd.ExecuteNonQuery() != 0)
			{
				Facebook.LogOut();
				registerForm.BackToLog();
				return;
			}

			registerForm.ErrorMessage("Unknown registration error.");
		}

		public async void LoginAsync(string name, string pass)
		{
			string query = string.Format("SELECT FB_mail, FB_password FROM Konta WHERE Name='{0}' AND Password='{1}'", name, Encrypter.HashThePassword(pass));
			var cmd = new MySqlCommand(query, connection);
			var reader = cmd.ExecuteReader();
			cmd.CommandTimeout = 2;
			string fbMail = null, fbPass = null;
			while (reader.Read())
			{
				fbMail = reader.GetString("FB_mail");
				fbPass = reader.GetString("FB_password");
			}
			reader.Close();
			if (fbMail != null && fbPass != null)
			{
				if(await Facebook.LogIn(fbMail, Encrypter.Decrypt(fbPass, pass)))
				{
					Program.username = name;
                    List<Friend> tmp = LoadFriendList(name);
                    if (tmp != null)
                        Program.StartKodunikator(tmp);
                    else
                        Program.UnseuccessLogin("Unexpected error. Cannot load friend list.");
				}
				else
				{
					Program.UnseuccessLogin("Facebook login fail.");
				}
				return;
			}
			Program.UnseuccessLogin("Username or password is incorrect.");
			return;
		}

        /// <summary>
        /// Pobiera liste znajomych z bazy danych.
        /// </summary>
        public List<Friend> LoadFriendList(string username)
        {
            List<Friend> friendList = new List<Friend>();

            string query = string.Format("SELECT Friends FROM Konta WHERE Name='{0}'", Program.username);
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            cmd.CommandTimeout = 2;
            reader.Read();
            string tmpFriends = reader.GetString(0);
            string[] friendsNames = tmpFriends.Split('|');
            if(friendsNames[0]!="")
            for(int i=0; i<friendsNames.Length; i++)
            {
                reader.Close();
                string query2 = string.Format("SELECT FB_ID FROM Konta WHERE Name='{0}'", friendsNames[i]);
                var cmd2 = new MySqlCommand(query2, connection);
                reader = cmd2.ExecuteReader();
                reader.Read();
                friendList.Add(new Friend(friendsNames[i], reader.GetString(0)));
            }
            reader.Close();
            return friendList;
        }

        /// <summary>
        /// Sprawdza czy istnieje dana osoba w bazie danych
        /// </summary>
        public bool FindPerson(string name)
        {
            string query = string.Format("SELECT Name FROM Konta WHERE Name='{0}'", name);
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            List<string> tmp = new List<string>();
            while (reader.Read())
            {
                tmp.Add(reader.GetString(0));
            }
            reader.Close();

            return tmp.Count > 0 ? true : false;
        }

        /// <summary>
        /// Dodaje nowego przyjaciela
        /// </summary>
        public void AddFriend(string name)
        {
            string newFriendList;
            string query = string.Format("SELECT Friends FROM Konta WHERE Name='{0}'", Program.username);
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            reader.Read();
            newFriendList = reader.GetString(0);
            if (newFriendList == null || newFriendList == "")
                newFriendList = name;
            else
            {
                newFriendList += "|";
                newFriendList += name;
            }

            reader.Close();
            string query2 = string.Format("UPDATE Konta SET Friends='{0}' WHERE Name='{1}'", newFriendList, Program.username);
            Log.NewLog(query2);
            var cmd2 = new MySqlCommand(query2, connection);
            if (cmd2.ExecuteNonQuery() != 0)
            {
                Log.NewLog("Zaktualizowanie listy przyjaciol. Nazwa: " + newFriendList);
            }
            
            LoadFriendList(Program.username);
        }
    }

}
