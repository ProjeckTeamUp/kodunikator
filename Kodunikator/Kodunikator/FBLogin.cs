using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodunikator
{
    public partial class FBLogin : Form
    {
        public FBLogin()
        {
            InitializeComponent();

            if(Facebook.IsPermamentLogin())
            {
                string[] tmp = Facebook.ReadMailPassword();

                b_savedAcc.Text = tmp[2];
                b_savedAcc.Show();
                b_anotherAcc.Show();

                Facebook.LogIn();
            }
            else
            {

            }
        }

        // Zalogowanie do konta fb które miało oznaczone stałe logowanie
        private void b_savedAcc_Click(object sender, EventArgs e)
        {
            Program.StartKodunikator();
        }
    }
}
