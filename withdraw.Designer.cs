namespace bankmanagementmainapplication
{
    partial class withdraw
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
            this.datelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accountxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.oldbalancetxt = new System.Windows.Forms.TextBox();
            this.amountxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "date";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(313, 28);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(0, 20);
            this.datelabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "accno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "old balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "get deatils";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "withdraw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accountxt
            // 
            this.accountxt.Location = new System.Drawing.Point(209, 151);
            this.accountxt.Name = "accountxt";
            this.accountxt.Size = new System.Drawing.Size(100, 26);
            this.accountxt.TabIndex = 9;
            this.accountxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(209, 257);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 26);
            this.nametxt.TabIndex = 10;
            // 
            // oldbalancetxt
            // 
            this.oldbalancetxt.Location = new System.Drawing.Point(229, 382);
            this.oldbalancetxt.Name = "oldbalancetxt";
            this.oldbalancetxt.Size = new System.Drawing.Size(100, 26);
            this.oldbalancetxt.TabIndex = 11;
            // 
            // amountxt
            // 
            this.amountxt.Location = new System.Drawing.Point(706, 224);
            this.amountxt.Name = "amountxt";
            this.amountxt.Size = new System.Drawing.Size(100, 26);
            this.amountxt.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(690, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 524);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.amountxt);
            this.Controls.Add(this.oldbalancetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.accountxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.label1);
            this.Name = "withdraw";
            this.Text = "withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox accountxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox oldbalancetxt;
        private System.Windows.Forms.TextBox amountxt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}