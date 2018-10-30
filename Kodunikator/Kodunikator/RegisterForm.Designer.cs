namespace Kodunikator
{
	partial class RegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.registration_sign = new System.Windows.Forms.Label();
			this.reg_name_field = new System.Windows.Forms.TextBox();
			this.reg_name_sign = new System.Windows.Forms.Label();
			this.reg_pass_sign = new System.Windows.Forms.Label();
			this.reg_conf_pass_sign = new System.Windows.Forms.Label();
			this.reg_pass_field = new System.Windows.Forms.TextBox();
			this.reg_conf_pass_field = new System.Windows.Forms.TextBox();
			this.register_btn = new System.Windows.Forms.Button();
			this.reg_error_msg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// registration_sign
			// 
			this.registration_sign.AutoSize = true;
			this.registration_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.registration_sign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.registration_sign.Location = new System.Drawing.Point(12, 9);
			this.registration_sign.Name = "registration_sign";
			this.registration_sign.Size = new System.Drawing.Size(154, 29);
			this.registration_sign.TabIndex = 0;
			this.registration_sign.Text = "Registration";
			// 
			// reg_name_field
			// 
			this.reg_name_field.Location = new System.Drawing.Point(142, 66);
			this.reg_name_field.MaxLength = 30;
			this.reg_name_field.Name = "reg_name_field";
			this.reg_name_field.Size = new System.Drawing.Size(186, 20);
			this.reg_name_field.TabIndex = 1;
			// 
			// reg_name_sign
			// 
			this.reg_name_sign.AutoSize = true;
			this.reg_name_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.reg_name_sign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.reg_name_sign.Location = new System.Drawing.Point(87, 70);
			this.reg_name_sign.Name = "reg_name_sign";
			this.reg_name_sign.Size = new System.Drawing.Size(49, 16);
			this.reg_name_sign.TabIndex = 2;
			this.reg_name_sign.Text = "Name";
			// 
			// reg_pass_sign
			// 
			this.reg_pass_sign.AutoSize = true;
			this.reg_pass_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.reg_pass_sign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.reg_pass_sign.Location = new System.Drawing.Point(60, 107);
			this.reg_pass_sign.Name = "reg_pass_sign";
			this.reg_pass_sign.Size = new System.Drawing.Size(76, 16);
			this.reg_pass_sign.TabIndex = 3;
			this.reg_pass_sign.Text = "Password";
			// 
			// reg_conf_pass_sign
			// 
			this.reg_conf_pass_sign.AutoSize = true;
			this.reg_conf_pass_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.reg_conf_pass_sign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.reg_conf_pass_sign.Location = new System.Drawing.Point(5, 146);
			this.reg_conf_pass_sign.Name = "reg_conf_pass_sign";
			this.reg_conf_pass_sign.Size = new System.Drawing.Size(131, 16);
			this.reg_conf_pass_sign.TabIndex = 4;
			this.reg_conf_pass_sign.Text = "Confirm password";
			// 
			// reg_pass_field
			// 
			this.reg_pass_field.Location = new System.Drawing.Point(142, 103);
			this.reg_pass_field.MaxLength = 30;
			this.reg_pass_field.Name = "reg_pass_field";
			this.reg_pass_field.PasswordChar = '*';
			this.reg_pass_field.Size = new System.Drawing.Size(186, 20);
			this.reg_pass_field.TabIndex = 5;
			// 
			// reg_conf_pass_field
			// 
			this.reg_conf_pass_field.Location = new System.Drawing.Point(142, 142);
			this.reg_conf_pass_field.MaxLength = 30;
			this.reg_conf_pass_field.Name = "reg_conf_pass_field";
			this.reg_conf_pass_field.PasswordChar = '*';
			this.reg_conf_pass_field.Size = new System.Drawing.Size(186, 20);
			this.reg_conf_pass_field.TabIndex = 6;
			// 
			// register_btn
			// 
			this.register_btn.Location = new System.Drawing.Point(252, 184);
			this.register_btn.Name = "register_btn";
			this.register_btn.Size = new System.Drawing.Size(75, 30);
			this.register_btn.TabIndex = 7;
			this.register_btn.Text = "Register";
			this.register_btn.UseVisualStyleBackColor = true;
			this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
			// 
			// reg_error_msg
			// 
			this.reg_error_msg.AutoSize = true;
			this.reg_error_msg.ForeColor = System.Drawing.Color.DarkRed;
			this.reg_error_msg.Location = new System.Drawing.Point(173, 24);
			this.reg_error_msg.Name = "reg_error_msg";
			this.reg_error_msg.Size = new System.Drawing.Size(29, 13);
			this.reg_error_msg.TabIndex = 8;
			this.reg_error_msg.Text = "Error";
			this.reg_error_msg.Visible = false;
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.register_btn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(568, 298);
			this.Controls.Add(this.reg_error_msg);
			this.Controls.Add(this.register_btn);
			this.Controls.Add(this.reg_conf_pass_field);
			this.Controls.Add(this.reg_pass_field);
			this.Controls.Add(this.reg_conf_pass_sign);
			this.Controls.Add(this.reg_pass_sign);
			this.Controls.Add(this.reg_name_sign);
			this.Controls.Add(this.reg_name_field);
			this.Controls.Add(this.registration_sign);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "RegisterForm";
			this.Text = "Registration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label registration_sign;
		private System.Windows.Forms.TextBox reg_name_field;
		private System.Windows.Forms.Label reg_name_sign;
		private System.Windows.Forms.Label reg_pass_sign;
		private System.Windows.Forms.Label reg_conf_pass_sign;
		private System.Windows.Forms.TextBox reg_pass_field;
		private System.Windows.Forms.TextBox reg_conf_pass_field;
		private System.Windows.Forms.Button register_btn;
		private System.Windows.Forms.Label reg_error_msg;
	}
}