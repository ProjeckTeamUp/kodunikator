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
	public partial class RegisterForm : Form
	{
		private DBConnection dbcon;

		public RegisterForm()
		{
			InitializeComponent();
		}

		public DBConnection Dbcon { get => dbcon; set => dbcon = value; }

		private void register_btn_Click(object sender, EventArgs e)
		{
			if (reg_name_field.Text.Length < 3 || reg_pass_field.Text.Length < 3)
			{
				reg_error_msg.Text = "Name and password should contain at least 3 symboles";
				reg_error_msg.Visible = true;
				return;
			}
			if(reg_pass_field.Text != reg_conf_pass_field.Text)
			{
				reg_error_msg.Text = "Password confirmation incorrect";
				reg_error_msg.Visible = true;
				return;
			}
			dbcon.RegisterUserAsync(reg_error_msg, reg_name_field.Text, reg_pass_field.Text, reg_fb_mail_field.Text, reg_fb_pass_field.Text);
		}
	}
}
