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
			Cursor = Cursors.WaitCursor;
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
					dbcon.LoginAsync(username_field.Text, password_field.Text);
				}
				else
				{
					UnseuccessLogin("Problem z połączeniem z bazą danych.");
				}
			}
			else
			{
				UnseuccessLogin("DataBase connection error. Try again.");
				ConnectToDatabase();
			}
		}

		public void SuccessLogin()
		{
			Log.NewLog("Udane zalogowanie do konta kodunikatora.");
			Cursor = Cursors.Arrow;
			dbcon.Close();
		}

		public void UnseuccessLogin(string errorMessage)
		{
			log_error_msg.Text = errorMessage;
			log_error_msg.Visible = true;
			Cursor = Cursors.Arrow;
			Log.NewLog(errorMessage);
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
