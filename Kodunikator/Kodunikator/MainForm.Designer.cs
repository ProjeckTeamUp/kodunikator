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
			this.message_feild = new System.Windows.Forms.TextBox();
			this.send_btn = new System.Windows.Forms.Button();
			this.conversation_view = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 450);
			this.panel1.TabIndex = 0;
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
			// 
			// conversation_view
			// 
			this.conversation_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.conversation_view.Location = new System.Drawing.Point(246, 12);
			this.conversation_view.Name = "conversation_view";
			this.conversation_view.Size = new System.Drawing.Size(542, 396);
			this.conversation_view.TabIndex = 3;
			this.conversation_view.UseCompatibleStateImageBehavior = false;
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox message_feild;
		private System.Windows.Forms.Button send_btn;
		private System.Windows.Forms.ListView conversation_view;
	}
}