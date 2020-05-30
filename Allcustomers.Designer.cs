namespace bankmanagementmainapplication
{
    partial class Allcustomers
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
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL Customers list";
            // 
            // balance
            // 
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "balance";
            this.balance.MinimumWidth = 8;
            this.balance.Name = "balance";
            this.balance.Width = 150;
            // 
            // customername
            // 
            this.customername.DataPropertyName = "Name";
            this.customername.HeaderText = "Name";
            this.customername.MinimumWidth = 8;
            this.customername.Name = "customername";
            this.customername.Width = 150;
            // 
            // Account_no
            // 
            this.Account_no.DataPropertyName = "Account_no";
            this.Account_no.HeaderText = "Account_no";
            this.Account_no.MinimumWidth = 8;
            this.Account_no.Name = "Account_no";
            this.Account_no.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_no,
            this.customername,
            this.balance});
            this.dataGridView1.Location = new System.Drawing.Point(104, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(860, 315);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Allcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Allcustomers";
            this.Text = "Allcustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_no;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}