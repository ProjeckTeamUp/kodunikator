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

		private MainForm mf;

		public AddFriend(MainForm main)
        {
            InitializeComponent();
			mf = main;
            dbCon = new DBConnection();
            dbCon.Connect();
        }

        private void button_add_friend_Click(object sender, EventArgs e)
        {
            string name = addFriend_textBox.Text;
            if (name == null)
            {
				
                printErrorMsg("Please enter friend nickname.");
                return;
            }

            if(name == Program.username)
            {
				printErrorMsg( "You cannot add youself.");
                return;
            }

            if(dbCon.FindPerson(name))
            {
				resultToMainForm(dbCon.AddFriend(name));
                this.Close();
            }
            else
            {
				printErrorMsg("Don't exist account with this nickname.");
                return; 
            }
        }

		private void resultToMainForm(List<Friend> friends)
		{
			mf.AddFriendFormResult(friends);
		}

		private void printErrorMsg(string msg)
		{
			new_friend_error_msg.Text = msg;
			new_friend_error_msg.Visible = true;
		}
    }
}
