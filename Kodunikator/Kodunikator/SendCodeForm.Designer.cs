namespace Kodunikator
{
	partial class SendCodeForm
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
			this.save_and_send_btn = new System.Windows.Forms.Button();
			this.code_file_name_box = new System.Windows.Forms.ComboBox();
			this.save_code_sign = new System.Windows.Forms.Label();
			this.save_code_error_msg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// save_and_send_btn
			// 
			this.save_and_send_btn.Location = new System.Drawing.Point(205, 139);
			this.save_and_send_btn.Name = "save_and_send_btn";
			this.save_and_send_btn.Size = new System.Drawing.Size(104, 32);
			this.save_and_send_btn.TabIndex = 2;
			this.save_and_send_btn.Text = "Save and Send";
			this.save_and_send_btn.UseVisualStyleBackColor = true;
			this.save_and_send_btn.Click += new System.EventHandler(this.save_and_send_btn_Click);
			// 
			// code_file_name_box
			// 
			this.code_file_name_box.FormattingEnabled = true;
			this.code_file_name_box.Location = new System.Drawing.Point(56, 72);
			this.code_file_name_box.Name = "code_file_name_box";
			this.code_file_name_box.Size = new System.Drawing.Size(253, 21);
			this.code_file_name_box.TabIndex = 1;
			// 
			// save_code_sign
			// 
			this.save_code_sign.AutoSize = true;
			this.save_code_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.save_code_sign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.save_code_sign.Location = new System.Drawing.Point(51, 9);
			this.save_code_sign.Name = "save_code_sign";
			this.save_code_sign.Size = new System.Drawing.Size(136, 29);
			this.save_code_sign.TabIndex = 5;
			this.save_code_sign.Text = "Save code";
			// 
			// save_code_error_msg
			// 
			this.save_code_error_msg.AutoSize = true;
			this.save_code_error_msg.ForeColor = System.Drawing.Color.DarkRed;
			this.save_code_error_msg.Location = new System.Drawing.Point(53, 56);
			this.save_code_error_msg.Name = "save_code_error_msg";
			this.save_code_error_msg.Size = new System.Drawing.Size(29, 13);
			this.save_code_error_msg.TabIndex = 7;
			this.save_code_error_msg.Text = "Error";
			this.save_code_error_msg.Visible = false;
			// 
			// SendCodeForm
			// 
			this.AcceptButton = this.save_and_send_btn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(383, 192);
			this.Controls.Add(this.save_code_error_msg);
			this.Controls.Add(this.save_code_sign);
			this.Controls.Add(this.code_file_name_box);
			this.Controls.Add(this.save_and_send_btn);
			this.Name = "SendCodeForm";
			this.Text = "SendCodeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button save_and_send_btn;
		private System.Windows.Forms.ComboBox code_file_name_box;
		private System.Windows.Forms.Label save_code_sign;
		private System.Windows.Forms.Label save_code_error_msg;
	}
}