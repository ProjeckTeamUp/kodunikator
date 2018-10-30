namespace Kodunikator
{
    partial class FBLogin
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
            this.b_savedAcc = new System.Windows.Forms.Button();
            this.b_anotherAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_savedAcc
            // 
            this.b_savedAcc.Location = new System.Drawing.Point(24, 55);
            this.b_savedAcc.Name = "b_savedAcc";
            this.b_savedAcc.Size = new System.Drawing.Size(230, 45);
            this.b_savedAcc.TabIndex = 0;
            this.b_savedAcc.UseVisualStyleBackColor = true;
            this.b_savedAcc.Visible = false;
            this.b_savedAcc.Click += new System.EventHandler(this.b_savedAcc_Click);
            // 
            // b_anotherAcc
            // 
            this.b_anotherAcc.Location = new System.Drawing.Point(26, 106);
            this.b_anotherAcc.Name = "b_anotherAcc";
            this.b_anotherAcc.Size = new System.Drawing.Size(228, 19);
            this.b_anotherAcc.TabIndex = 1;
            this.b_anotherAcc.Text = "It\'s not me...";
            this.b_anotherAcc.UseVisualStyleBackColor = true;
            this.b_anotherAcc.Visible = false;
            // 
            // FBLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.b_anotherAcc);
            this.Controls.Add(this.b_savedAcc);
            this.Name = "FBLogin";
            this.Text = "FBLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_savedAcc;
        private System.Windows.Forms.Button b_anotherAcc;
    }
}