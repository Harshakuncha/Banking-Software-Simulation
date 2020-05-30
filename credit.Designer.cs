namespace bankmanagementmainapplication
{
    partial class credit
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
            this.Currentdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.oldbalancetxt = new System.Windows.Forms.TextBox();
            this.dpamounttxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Currentdate
            // 
            this.Currentdate.AutoSize = true;
            this.Currentdate.Location = new System.Drawing.Point(200, 35);
            this.Currentdate.Name = "Currentdate";
            this.Currentdate.Size = new System.Drawing.Size(91, 20);
            this.Currentdate.TabIndex = 0;
            this.Currentdate.Text = "currentdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "enter account number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "oldbalance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "deposit amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "fetch details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accnotxt
            // 
            this.accnotxt.Location = new System.Drawing.Point(234, 104);
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(100, 26);
            this.accnotxt.TabIndex = 9;
            this.accnotxt.TextChanged += new System.EventHandler(this.accnotxt_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(153, 162);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 26);
            this.nametxt.TabIndex = 10;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // oldbalancetxt
            // 
            this.oldbalancetxt.Location = new System.Drawing.Point(189, 230);
            this.oldbalancetxt.Name = "oldbalancetxt";
            this.oldbalancetxt.Size = new System.Drawing.Size(100, 26);
            this.oldbalancetxt.TabIndex = 11;
            this.oldbalancetxt.TextChanged += new System.EventHandler(this.oldbalancetxt_TextChanged);
            // 
            // dpamounttxt
            // 
            this.dpamounttxt.Location = new System.Drawing.Point(189, 347);
            this.dpamounttxt.Name = "dpamounttxt";
            this.dpamounttxt.Size = new System.Drawing.Size(100, 26);
            this.dpamounttxt.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(297, 35);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(0, 20);
            this.datelabel.TabIndex = 14;
            // 
            // credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dpamounttxt);
            this.Controls.Add(this.oldbalancetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Currentdate);
            this.Name = "credit";
            this.Text = "credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Currentdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox oldbalancetxt;
        private System.Windows.Forms.TextBox dpamounttxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label datelabel;
    }
}