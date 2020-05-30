namespace bankmanagementmainapplication
{
    partial class transferform
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
            this.datelbltxt = new System.Windows.Forms.Label();
            this.fromaccounttxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.desaccounttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tranfertxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "currentdate";
            // 
            // datelbltxt
            // 
            this.datelbltxt.AutoSize = true;
            this.datelbltxt.Location = new System.Drawing.Point(471, 36);
            this.datelbltxt.Name = "datelbltxt";
            this.datelbltxt.Size = new System.Drawing.Size(0, 20);
            this.datelbltxt.TabIndex = 1;
            // 
            // fromaccounttxt
            // 
            this.fromaccounttxt.Location = new System.Drawing.Point(279, 105);
            this.fromaccounttxt.Name = "fromaccounttxt";
            this.fromaccounttxt.Size = new System.Drawing.Size(231, 26);
            this.fromaccounttxt.TabIndex = 2;
            this.fromaccounttxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(291, 168);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(219, 26);
            this.nametxt.TabIndex = 3;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(291, 239);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(219, 26);
            this.amounttxt.TabIndex = 4;
            // 
            // desaccounttxt
            // 
            this.desaccounttxt.Location = new System.Drawing.Point(291, 312);
            this.desaccounttxt.Name = "desaccounttxt";
            this.desaccounttxt.Size = new System.Drawing.Size(219, 26);
            this.desaccounttxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "From account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "current amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destination account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "transfer amount";
            // 
            // tranfertxt
            // 
            this.tranfertxt.Location = new System.Drawing.Point(291, 368);
            this.tranfertxt.Name = "tranfertxt";
            this.tranfertxt.Size = new System.Drawing.Size(219, 26);
            this.tranfertxt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(333, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Transfer amount";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transferform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tranfertxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desaccounttxt);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.fromaccounttxt);
            this.Controls.Add(this.datelbltxt);
            this.Controls.Add(this.label1);
            this.Name = "transferform";
            this.Text = "transferform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelbltxt;
        private System.Windows.Forms.TextBox fromaccounttxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.TextBox desaccounttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tranfertxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}