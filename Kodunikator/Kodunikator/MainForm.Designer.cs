using System;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel = new System.Windows.Forms.Panel();
            this.friends_list = new System.Windows.Forms.ListBox();
            this.main_username_sign = new System.Windows.Forms.Label();
            this.message_feild = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.conversation_view = new System.Windows.Forms.ListBox();
            this.sendCode_btn = new System.Windows.Forms.Button();
            this.sendFile_btn = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.friends_list);
            this.panel.Controls.Add(this.main_username_sign);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(240, 593);
            this.panel.TabIndex = 0;
            // 
            // friends_list
            // 
            this.friends_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.friends_list.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.friends_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.friends_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.friends_list.FormattingEnabled = true;
            this.friends_list.ItemHeight = 20;
            this.friends_list.Location = new System.Drawing.Point(11, 81);
            this.friends_list.Name = "friends_list";
            this.friends_list.Size = new System.Drawing.Size(215, 480);
            this.friends_list.TabIndex = 2;
            this.friends_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.friends_list_View_DrawItem);
            this.friends_list.SelectedIndexChanged += new System.EventHandler(this.friends_list_SelectedIndexChanged);
            this.friends_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.friends_list_MouseDown);
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
            this.message_feild.Location = new System.Drawing.Point(246, 464);
            this.message_feild.Multiline = true;
            this.message_feild.Name = "message_feild";
            this.message_feild.Size = new System.Drawing.Size(630, 87);
            this.message_feild.TabIndex = 1;
            // 
            // send_btn
            // 
            this.send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send_btn.Location = new System.Drawing.Point(665, 559);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(79, 30);
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
            this.conversation_view.Size = new System.Drawing.Size(630, 446);
            this.conversation_view.TabIndex = 4;
            this.conversation_view.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.conversation_view_View_DrawItem);
            this.conversation_view.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.conversation_view_MeasureItem);
            this.conversation_view.SelectedIndexChanged += new System.EventHandler(this.conversation_view_SelectedIndexChanged);
            // 
            // sendCode_btn
            // 
            this.sendCode_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendCode_btn.Location = new System.Drawing.Point(750, 559);
            this.sendCode_btn.Name = "sendCode_btn";
            this.sendCode_btn.Size = new System.Drawing.Size(79, 30);
            this.sendCode_btn.TabIndex = 5;
            this.sendCode_btn.Text = "Send Code";
            this.sendCode_btn.UseVisualStyleBackColor = true;
            this.sendCode_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendFile_btn
            // 
            this.sendFile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendFile_btn.BackgroundImage")));
            this.sendFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendFile_btn.Location = new System.Drawing.Point(835, 559);
            this.sendFile_btn.Name = "sendFile_btn";
            this.sendFile_btn.Size = new System.Drawing.Size(41, 30);
            this.sendFile_btn.TabIndex = 6;
            this.sendFile_btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.send_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 593);
            this.Controls.Add(this.sendFile_btn);
            this.Controls.Add(this.sendCode_btn);
            this.Controls.Add(this.conversation_view);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.message_feild);
            this.Controls.Add(this.panel);
            this.Name = "MainForm";
            this.Text = "Kodunikator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void newFriends_list_MouseDown(object sender, MouseEventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.TextBox message_feild;
		private System.Windows.Forms.Button send_btn;
		private System.Windows.Forms.Label main_username_sign;
		private System.Windows.Forms.ListBox conversation_view;
		private System.Windows.Forms.ListBox friends_list;
        private Button sendCode_btn;
        private Button sendFile_btn;
    }
}