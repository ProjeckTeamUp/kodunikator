using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodunikator
{
    public partial class AddFriend : Form
    {
        private DBConnection dbCon;

        public AddFriend()
        {
            InitializeComponent();
            dbCon = new DBConnection();
            dbCon.Connect();
        }

        private void button_add_friend_Click(object sender, EventArgs e)
        {
            string name = addFriend_textBox.Text;
            if (name == null)
            {
                addFriend_text.Text = "Please enter friend nickname.";
                return;
            }

            if(name == Program.username)
            {
                addFriend_text.Text = "You cannot add youself.";
                return;
            }

            if(dbCon.FindPerson(name))
            {
                dbCon.AddFriend(name);
                this.Close();
            }
            else
            {
                addFriend_text.Text = "Don't exist account with this nickname.";
                return; 
            }
        }
    }
}
