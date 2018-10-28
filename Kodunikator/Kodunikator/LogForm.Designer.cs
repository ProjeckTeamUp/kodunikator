namespace Kodunikator
{
    partial class LogForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
			this.sign_btn = new System.Windows.Forms.Button();
			this.username_field = new System.Windows.Forms.TextBox();
			this.password_field = new System.Windows.Forms.TextBox();
			this.login_sign = new System.Windows.Forms.Label();
			this.register_btn = new System.Windows.Forms.Button();
			this.log_error_msg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// sign_btn
			// 
			this.sign_btn.Location = new System.Drawing.Point(127, 147);
			this.sign_btn.Name = "sign_btn";
			this.sign_btn.Size = new System.Drawing.Size(90, 34);
			this.sign_btn.TabIndex = 1;
			this.sign_btn.Text = "Sign in";
			this.sign_btn.UseVisualStyleBackColor = true;
			this.sign_btn.Click += new System.EventHandler(this.sign_btn_Click);
			// 
			// username_field
			// 
			this.username_field.Location = new System.Drawing.Point(55, 64);
			this.username_field.MaxLength = 30;
			this.username_field.Name = "username_field";
			this.username_field.Size = new System.Drawing.Size(162, 20);
			this.username_field.TabIndex = 2;
			this.username_field.Text = "name";
			// 
			// password_field
			// 
			this.password_field.Location = new System.Drawing.Point(55, 108);
			this.password_field.MaxLength = 30;
			this.password_field.Name = "password_field";
			this.password_field.PasswordChar = '*';
			this.password_field.Size = new System.Drawing.Size(162, 20);
			this.password_field.TabIndex = 3;
			this.password_field.Text = "password";
			// 
			// login_sign
			// 
			this.login_sign.AutoSize = true;
			this.login_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.login_sign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.login_sign.Location = new System.Drawing.Point(50, 19);
			this.login_sign.Name = "login_sign";
			this.login_sign.Size = new System.Drawing.Size(78, 29);
			this.login_sign.TabIndex = 4;
			this.login_sign.Text = "Login";
			// 
			// register_btn
			// 
			this.register_btn.Location = new System.Drawing.Point(13, 226);
			this.register_btn.Name = "register_btn";
			this.register_btn.Size = new System.Drawing.Size(75, 23);
			this.register_btn.TabIndex = 5;
			this.register_btn.Text = "Register";
			this.register_btn.UseVisualStyleBackColor = true;
			this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
			// 
			// log_error_msg
			// 
			this.log_error_msg.AutoSize = true;
			this.log_error_msg.ForeColor = System.Drawing.Color.DarkRed;
			this.log_error_msg.Location = new System.Drawing.Point(135, 34);
			this.log_error_msg.Name = "log_error_msg";
			this.log_error_msg.Size = new System.Drawing.Size(29, 13);
			this.log_error_msg.TabIndex = 6;
			this.log_error_msg.Text = "Error";
			this.log_error_msg.Visible = false;
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.log_error_msg);
			this.Controls.Add(this.register_btn);
			this.Controls.Add(this.login_sign);
			this.Controls.Add(this.password_field);
			this.Controls.Add(this.username_field);
			this.Controls.Add(this.sign_btn);
			this.Name = "LogForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sign_btn;
		private System.Windows.Forms.TextBox username_field;
		private System.Windows.Forms.TextBox password_field;
		private System.Windows.Forms.Label login_sign;
		private System.Windows.Forms.Button register_btn;
		private System.Windows.Forms.Label log_error_msg;
	}
}

