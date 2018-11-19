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
            this.SuspendLayout();
            // 
            // addFriend_text
            // 
            this.addFriend_text.AutoSize = true;
            this.addFriend_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addFriend_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addFriend_text.Location = new System.Drawing.Point(51, 38);
            this.addFriend_text.Name = "addFriend_text";
            this.addFriend_text.Size = new System.Drawing.Size(262, 20);
            this.addFriend_text.TabIndex = 0;
            this.addFriend_text.Text = "Add new friend (enter his nickname)";
            // 
            // addFriend_textBox
            // 
            this.addFriend_textBox.Location = new System.Drawing.Point(69, 86);
            this.addFriend_textBox.Name = "addFriend_textBox";
            this.addFriend_textBox.Size = new System.Drawing.Size(214, 20);
            this.addFriend_textBox.TabIndex = 1;
            // 
            // button_add_friend
            // 
            this.button_add_friend.Location = new System.Drawing.Point(113, 136);
            this.button_add_friend.Name = "button_add_friend";
            this.button_add_friend.Size = new System.Drawing.Size(131, 33);
            this.button_add_friend.TabIndex = 2;
            this.button_add_friend.Text = "Add";
            this.button_add_friend.UseVisualStyleBackColor = true;
            this.button_add_friend.Click += new System.EventHandler(this.button_add_friend_Click);
            // 
            // AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(367, 261);
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
    }
}