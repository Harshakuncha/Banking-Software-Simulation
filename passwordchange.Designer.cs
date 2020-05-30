namespace bankmanagementmainapplication
{
    partial class passwordchange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.retypepass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "change";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "oldpassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "newpassword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "retypepassword";
            // 
            // oldpass
            // 
            this.oldpass.Location = new System.Drawing.Point(257, 166);
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(144, 26);
            this.oldpass.TabIndex = 6;
            this.oldpass.TextChanged += new System.EventHandler(this.oldpass_TextChanged);
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(257, 227);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(144, 26);
            this.newpass.TabIndex = 7;
            // 
            // retypepass
            // 
            this.retypepass.Location = new System.Drawing.Point(257, 312);
            this.retypepass.Name = "retypepass";
            this.retypepass.Size = new System.Drawing.Size(144, 26);
            this.retypepass.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(257, 89);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(144, 26);
            this.usertxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bankmanagementmainapplication.Properties.Resources.th;
            this.pictureBox1.Location = new System.Drawing.Point(615, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // passwordchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.retypepass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.oldpass);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "passwordchange";
            this.Text = "passwordchange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox retypepass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}