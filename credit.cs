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
    public partial class credit : Form
    {
        public credit()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("cash");
            comboBox1.Items.Add("cheque");
        }

        private void loaddate()
        {
            //throw new NotImplementedException();

            datelabel.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankmanagement_dbEntities2 con = new bankmanagement_dbEntities2();
            decimal no = Convert.ToDecimal(accnotxt.Text);
            var item = (from u in con.userAccounts where u.Account_no == no select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbalancetxt.Text = Convert.ToString(item.balance);













        }

        private void accnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldbalancetxt_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            bankmanagement_dbEntities2 con = new bankmanagement_dbEntities2();
            NewAccount ac = new NewAccount();
            deposit__ dp = new deposit__();
            decimal no = Convert.ToDecimal(accnotxt.Text);
            dp.Name = nametxt.Text;
            dp.old_balance = Convert.ToDecimal(oldbalancetxt.Text);
            dp.depamount = Convert.ToDecimal(dpamounttxt.Text);
            dp.Account_no = Convert.ToDecimal(value: accnotxt.Text);
            dp.date = datelabel.Text;
            dp.Mode = comboBox1.SelectedItem.ToString();
            con.deposit__.Add(dp);
            con.SaveChanges();
            var item = (from u in con.userAccounts where u.Account_no == no select u).FirstOrDefault();
            item.balance = item.balance + Convert.ToDecimal(dpamounttxt.Text);
            con.SaveChanges();
            MessageBox.Show("deposit success");

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
