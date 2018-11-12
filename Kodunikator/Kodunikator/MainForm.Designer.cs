namespace Kodunikator
{
	partial class MainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.main_facebook_name_sign = new System.Windows.Forms.Label();
			this.main_username_sign = new System.Windows.Forms.Label();
			this.message_feild = new System.Windows.Forms.TextBox();
			this.send_btn = new System.Windows.Forms.Button();
			this.conversation_view = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.main_facebook_name_sign);
			this.panel1.Controls.Add(this.main_username_sign);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 450);
			this.panel1.TabIndex = 0;
			// 
			// main_facebook_name_sign
			// 
			this.main_facebook_name_sign.AutoSize = true;
			this.main_facebook_name_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.main_facebook_name_sign.Location = new System.Drawing.Point(17, 46);
			this.main_facebook_name_sign.Name = "main_facebook_name_sign";
			this.main_facebook_name_sign.Size = new System.Drawing.Size(102, 16);
			this.main_facebook_name_sign.TabIndex = 1;
			this.main_facebook_name_sign.Text = "facebook name";
			// 
			// main_username_sign
			// 
			this.main_username_sign.AutoSize = true;
			this.main_username_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.main_username_sign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.main_username_sign.Location = new System.Drawing.Point(11, 11);
			this.main_username_sign.Name = "main_username_sign";
			this.main_username_sign.Size = new System.Drawing.Size(76, 31);
			this.main_username_sign.TabIndex = 0;
			this.main_username_sign.Text = "User";
			// 
			// message_feild
			// 
			this.message_feild.AcceptsTab = true;
			this.message_feild.AllowDrop = true;
			this.message_feild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.message_feild.Location = new System.Drawing.Point(246, 414);
			this.message_feild.Multiline = true;
			this.message_feild.Name = "message_feild";
			this.message_feild.Size = new System.Drawing.Size(473, 36);
			this.message_feild.TabIndex = 1;
			// 
			// send_btn
			// 
			this.send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.send_btn.Location = new System.Drawing.Point(725, 414);
			this.send_btn.Name = "send_btn";
			this.send_btn.Size = new System.Drawing.Size(75, 36);
			this.send_btn.TabIndex = 2;
			this.send_btn.Text = "Send";
			this.send_btn.UseVisualStyleBackColor = true;
			this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
			// 
			// conversation_view
			// 
			this.conversation_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.conversation_view.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.conversation_view.FormattingEnabled = true;
			this.conversation_view.Location = new System.Drawing.Point(246, 12);
			this.conversation_view.Name = "conversation_view";
			this.conversation_view.Size = new System.Drawing.Size(542, 394);
			this.conversation_view.TabIndex = 4;
			this.conversation_view.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.conversation_view_View_DrawItem);
			this.conversation_view.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.conversation_view_MeasureItem);
			this.conversation_view.SelectedIndexChanged += new System.EventHandler(this.conversation_view_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AcceptButton = this.send_btn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.conversation_view);
			this.Controls.Add(this.send_btn);
			this.Controls.Add(this.message_feild);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Kodunikator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox message_feild;
		private System.Windows.Forms.Button send_btn;
		private System.Windows.Forms.Label main_facebook_name_sign;
		private System.Windows.Forms.Label main_username_sign;
		private System.Windows.Forms.ListBox conversation_view;
	}
}