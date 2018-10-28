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
                if (dbcon.Login(username_field.Text, password_field.Text))
                {
                    login_sign.Text = "Success";
                    Log.NewLog("Udane zalogowanie do konta kodunikatora.");
                    //dbcon.Close();
                }
                else
                {
                    log_error_msg.Text = "Wrong user name or password";
					log_error_msg.Visible = true;
                    Log.NewLog("Nieudana próba zalogowania do konta kodunikatora.");
                }
            }
            else
                Log.NewError("Problem z połączeniem z bazą danych.");
		}

		private void register_btn_Click(object sender, EventArgs e)
		{
			RegisterForm tmp = new RegisterForm();
			tmp.Dbcon = dbcon;
			tmp.Show();
			Log.NewError("User chce się zarejestrować.");
		}
	}
}
