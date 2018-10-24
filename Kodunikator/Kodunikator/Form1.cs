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
        }

        /// <summary>
        /// Łączy z baza danych.
        /// </summary>
        public void ConnectToDatabase()
        {
            DBConnection dbcon = new DBConnection();
            dbcon.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string query = "SELECT Name FROM Konta";
            List<string> rekordy = new List<string>();
            var cmd = new MySqlCommand(query, dbcon.connection);
            var reader = cmd.ExecuteReader();           
            while (reader.Read())
            {
                rekordy.Add(reader.GetString(0));
                label1.Text = rekordy[0];
            
            } */
        }
    }
}
