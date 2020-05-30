using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankmanagementmainapplication
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            // throw new NotImplementedException();
            comboBox1.Items.Add("cash");
            comboBox1.Items.Add("cheque");

        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            datelabel.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bankmanagement_dbEntities2 con = new bankmanagement_dbEntities2();
            decimal no = Convert.ToDecimal(accountxt.Text);
            var item = (from u in con.userAccounts where u.Account_no == no select u).FirstOrDefault();
          
            
            //oldbalancetxt.Text = Convert.ToString(item.balance);
           //nametxt.Text = item.Name;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bankmanagement_dbEntities2 con = new bankmanagement_dbEntities2();
            NewAccount ac = new NewAccount();
            debit dp = new debit();
            
            decimal no = Convert.ToDecimal(accountxt.Text);
            dp.Name = nametxt.Text;
            dp.old_balance = Convert.ToDecimal(oldbalancetxt.Text);
            
            dp.Account_no = Convert.ToDecimal(value: accountxt.Text);
            dp.Date= datelabel.Text;
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(amountxt.Text);
            con.debits.Add(dp);
            con.SaveChanges();
            var item = (from u in con.userAccounts where u.Account_no == no select u).FirstOrDefault();
            item.balance = item.balance - Convert.ToDecimal(amountxt.Text);
            con.SaveChanges();
            MessageBox.Show("money withdrawn");



        }

        private void button1_Click(object sender, EventArgs e)
        {
           bankmanagement_dbEntities2 con =new  bankmanagement_dbEntities2();
            decimal accno = Convert.ToDecimal(accountxt.Text);
            var item = con.userAccounts.Where(a => a.Account_no == accno).FirstOrDefault();

            accountxt.Text = item.Account_no.ToString();
            nametxt.Text = item.Name;
            oldbalancetxt.Text = Convert.ToString(item.balance);


        }
    }
}
