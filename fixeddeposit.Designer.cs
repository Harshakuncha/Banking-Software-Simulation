namespace bankmanagementmainapplication
{
    partial class fixeddeposit
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
            this.Date = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.rupeestxt = new System.Windows.Forms.TextBox();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.intresttxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(304, 44);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(41, 20);
            this.Date.TabIndex = 0;
            this.Date.Text = "date";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(400, 44);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(0, 20);
            this.datelabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "rupees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "period(day)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "intrest";
            // 
            // accnotxt
            // 
            this.accnotxt.Location = new System.Drawing.Point(193, 113);
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(100, 26);
            this.accnotxt.TabIndex = 7;
            // 
            // rupeestxt
            // 
            this.rupeestxt.Location = new System.Drawing.Point(210, 233);
            this.rupeestxt.Name = "rupeestxt";
            this.rupeestxt.Size = new System.Drawing.Size(100, 26);
            this.rupeestxt.TabIndex = 9;
            // 
            // periodtxt
            // 
            this.periodtxt.Location = new System.Drawing.Point(178, 294);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.Size = new System.Drawing.Size(100, 26);
            this.periodtxt.TabIndex = 10;
            // 
            // intresttxt
            // 
            this.intresttxt.Location = new System.Drawing.Point(193, 363);
            this.intresttxt.Name = "intresttxt";
            this.intresttxt.Size = new System.Drawing.Size(142, 26);
            this.intresttxt.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 75);
            this.button1.TabIndex = 13;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fixeddeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.intresttxt);
            this.Controls.Add(this.periodtxt);
            this.Controls.Add(this.rupeestxt);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.Date);
            this.Name = "fixeddeposit";
            this.Text = "fixeddeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.TextBox rupeestxt;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.TextBox intresttxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}