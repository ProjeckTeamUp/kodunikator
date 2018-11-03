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

		public void ErrorMessage(string msg)
		{
			Cursor = Cursors.Arrow;
			reg_error_msg.Text = msg;
			reg_error_msg.Visible = true;
			Log.NewLog(msg);
		}

		public void BackToLog()
		{
			Cursor = Cursors.Arrow;
			Log.NewLog("User successfully registered");
			Close();
		}

		public DBConnection Dbcon { get => dbcon; set => dbcon = value; }

		private void register_btn_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			if (reg_name_field.Text.Length < 3 || reg_pass_field.Text.Length < 3)
			{
				reg_error_msg.Text = "Name and password should contain at least 3 symboles.";
				reg_error_msg.Visible = true;
				Cursor = Cursors.Arrow;
				return;
			}
			if(reg_pass_field.Text != reg_conf_pass_field.Text)
			{
				reg_error_msg.Text = "Password confirmation incorrect.";
				reg_error_msg.Visible = true;
				Cursor = Cursors.Arrow;
				return;
			}
			if(reg_fb_mail_field.Text.Length < 4 || reg_fb_pass_field.Text.Length < 5)
			{
				reg_error_msg.Text = "Facebook e-mail or password is incorrect.";
				reg_error_msg.Visible = true;
				Cursor = Cursors.Arrow;
				return;
			}
			if (!reg_fb_mail_field.Text.Contains('@'))
			{
				reg_error_msg.Text = "Facebook e-mail is incorrect.";
				reg_error_msg.Visible = true;
				Cursor = Cursors.Arrow;
				return;
			}
			dbcon.RegisterUserAsync(this, reg_name_field.Text, reg_pass_field.Text, reg_fb_mail_field.Text, reg_fb_pass_field.Text);
		}
	}
}
