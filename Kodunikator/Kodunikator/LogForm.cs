using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kodunikator
{
    public partial class LogForm : Form
    {
        private DBConnection dbcon; // odwołanie do łącza z baza danych

		private RegisterForm registerForm;

        public LogForm()
        {
			InitializeComponent();
			ConnectToDatabase();
		}

        /// <summary>
        /// Łączy z baza danych.
        /// </summary>
        public void ConnectToDatabase()
        {
            dbcon = new DBConnection();
            dbcon.Connect();
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
			if (dbcon != null)
			{
				for(int i=0; i<5; i++)
				{
					if (!dbcon.isConnected())
					{
						dbcon.Connect();
						System.Threading.Thread.Sleep(50);
					}
					else
						break;
				}
				if (dbcon.isConnected())
				{
					if (dbcon.Login(username_field.Text, password_field.Text))
					{
						Log.NewLog("Udane zalogowanie do konta kodunikatora.");
						dbcon.Close();
                        Program.StartKodunikator();
					}
					else
					{
						log_error_msg.Text = "Wrong user name or password";
						log_error_msg.Visible = true;
						Log.NewLog("Nieudana próba zalogowania do konta kodunikatora.");
					}
				}
				else
				{
					Log.NewError("Problem z połączeniem z bazą danych.");
					log_error_msg.Text = "DataBase connection error.";
					log_error_msg.Visible = true;
				}
			}
			else
			{
				Log.NewError("Problem z połączeniem z bazą danych. Ponowna próba połączenia się.");
				log_error_msg.Text = "DataBase connection error. Try again.";
				log_error_msg.Visible = true;
				ConnectToDatabase();
			}
		}

		private void register_btn_Click(object sender, EventArgs e)
		{
			registerForm = new RegisterForm();
			registerForm.Dbcon = dbcon;
			registerForm.Location = this.Location;
			registerForm.StartPosition = FormStartPosition.Manual;
			registerForm.FormClosing += delegate { this.Show(); };
			registerForm.Show();
			this.Hide();
			Log.NewLog("User chce się zarejestrować.");
		}
	}
}
