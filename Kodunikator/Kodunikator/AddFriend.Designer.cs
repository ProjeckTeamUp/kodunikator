namespace Kodunikator
{
    partial class AddFriend
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
			this.addFriend_text = new System.Windows.Forms.Label();
			this.addFriend_textBox = new System.Windows.Forms.TextBox();
			this.button_add_friend = new System.Windows.Forms.Button();
			this.new_friend_error_msg = new System.Windows.Forms.Label();
			this.addFriend_text2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addFriend_text
			// 
			this.addFriend_text.AutoSize = true;
			this.addFriend_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addFriend_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.addFriend_text.Location = new System.Drawing.Point(12, 9);
			this.addFriend_text.Name = "addFriend_text";
			this.addFriend_text.Size = new System.Drawing.Size(176, 25);
			this.addFriend_text.TabIndex = 0;
			this.addFriend_text.Text = "Add new friend ";
			// 
			// addFriend_textBox
			// 
			this.addFriend_textBox.Location = new System.Drawing.Point(74, 94);
			this.addFriend_textBox.Name = "addFriend_textBox";
			this.addFriend_textBox.Size = new System.Drawing.Size(214, 20);
			this.addFriend_textBox.TabIndex = 1;
			// 
			// button_add_friend
			// 
			this.button_add_friend.Location = new System.Drawing.Point(224, 168);
			this.button_add_friend.Name = "button_add_friend";
			this.button_add_friend.Size = new System.Drawing.Size(131, 33);
			this.button_add_friend.TabIndex = 2;
			this.button_add_friend.Text = "Add";
			this.button_add_friend.UseVisualStyleBackColor = true;
			this.button_add_friend.Click += new System.EventHandler(this.button_add_friend_Click);
			// 
			// new_friend_error_msg
			// 
			this.new_friend_error_msg.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.new_friend_error_msg.AutoSize = true;
			this.new_friend_error_msg.ForeColor = System.Drawing.Color.DarkRed;
			this.new_friend_error_msg.Location = new System.Drawing.Point(71, 63);
			this.new_friend_error_msg.Name = "new_friend_error_msg";
			this.new_friend_error_msg.Size = new System.Drawing.Size(29, 13);
			this.new_friend_error_msg.TabIndex = 7;
			this.new_friend_error_msg.Text = "Error";
			this.new_friend_error_msg.Visible = false;
			// 
			// addFriend_text2
			// 
			this.addFriend_text2.AutoSize = true;
			this.addFriend_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addFriend_text2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.addFriend_text2.Location = new System.Drawing.Point(12, 92);
			this.addFriend_text2.Name = "addFriend_text2";
			this.addFriend_text2.Size = new System.Drawing.Size(51, 20);
			this.addFriend_text2.TabIndex = 8;
			this.addFriend_text2.Text = "Name";
			// 
			// AddFriend
			// 
			this.AcceptButton = this.button_add_friend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(367, 213);
			this.Controls.Add(this.addFriend_text2);
			this.Controls.Add(this.new_friend_error_msg);
			this.Controls.Add(this.button_add_friend);
			this.Controls.Add(this.addFriend_textBox);
			this.Controls.Add(this.addFriend_text);
			this.Name = "AddFriend";
			this.Text = "AddFriend";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addFriend_text;
        private System.Windows.Forms.TextBox addFriend_textBox;
        private System.Windows.Forms.Button button_add_friend;
		private System.Windows.Forms.Label new_friend_error_msg;
		private System.Windows.Forms.Label addFriend_text2;
	}
}