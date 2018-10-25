using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // DEL
using MySql.Data.MySqlClient; // DEL 

namespace Kodunikator
{
    public partial class Form1 : Form
    {
        private DBConnection dbcon; // odwołanie do łącza z baza danych

        public Form1()
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
			if (dbcon != null && dbcon.Login(username_field.Text, password_field.Text))
			{
				login_sign.Text = "Success";
				//dbcon.Close();
			}
		}
	}
}
