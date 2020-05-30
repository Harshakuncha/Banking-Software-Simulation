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
    public partial class transferform : Form
    {
        public transferform()
        {
            InitializeComponent();
            loaddate();

        }

        private void loaddate()
        {
            //hrow new NotImplementedException();
            datelbltxt.Text = DateTime.UtcNow.ToString("mm/dd/yyyy");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankmanagement_dbEntities2 con = new bankmanagement_dbEntities2();
            decimal no = Convert.ToDecimal(fromaccounttxt.Text);
            var item = (from u in con.userAccounts where u.Account_no == no select u).FirstOrDefault();
            nametxt.Text = item.Name;
            amounttxt.Text = Convert.ToString(item.balance);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bankmanagement_dbEntities2 con = new bankmanagement_dbEntities2();
            decimal no = Convert.ToDecimal(fromaccounttxt.Text);
            var item = (from u in con.userAccounts where u.Account_no == no select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.balance);
            decimal totalbal = Convert.ToDecimal(tranfertxt.Text);
            decimal trasferacc = Convert.ToDecimal(desaccounttxt.Text);
            if(b1>totalbal)
            {
                userAccount item2 = (from u in con.userAccounts where u.Account_no == trasferacc select u).FirstOrDefault();
                item2.balance = item2.balance + totalbal;
                item.balance = item.balance - totalbal;
                //on.SaveChanges();
                Transfer trans = new Transfer();
                trans.Account_no = Convert.ToDecimal(fromaccounttxt.Text);
                trans.Totransfer = Convert.ToDecimal(desaccounttxt.Text);
                trans.Date = DateTime.UtcNow.ToString();
                trans.Name = nametxt.Text;
                trans.Balance = Convert.ToDecimal(tranfertxt.Text);
                con.Transfers.Add(trans);
                con.SaveChanges();
                MessageBox.Show("transfer complete");





            }

        }
    }
}
