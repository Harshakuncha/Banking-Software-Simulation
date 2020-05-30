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
    public partial class fixeddeposit : Form
    {
        public fixeddeposit()
        {
            InitializeComponent();
            loaddate();
            loadmode();

        }

        private void loadmode()
        {
            //row new NotImplementedException();
            comboBox1.Items.Add("cash");
            comboBox1.Items.Add("cheque");
        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            datelabel.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bankmanagement_dbEntities2 dbe = new bankmanagement_dbEntities2();
            decimal no = Convert.ToDecimal(accnotxt.Text);
            var accounts = dbe.userAccounts.Where(x => x.Account_no==no).SingleOrDefault();
            FD farm = new FD();
            farm.Account_no = Convert.ToDecimal(accnotxt.Text);
            farm.Mode = comboBox1.SelectedItem.ToString();
            farm.Rupees = rupeestxt.Text;
            farm.period = Convert.ToInt32(periodtxt.Text);
            farm.intrest = Convert.ToDecimal(intresttxt.Text);
            farm.start_date = DateTime.UtcNow.ToString("MM/dd/yyyy");
            farm.maturity_date = (DateTime.UtcNow.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("MM/dd/yyyy");
            farm.maturity_amount = ((Convert.ToDecimal(rupeestxt.Text) * Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(intresttxt.Text) / (100 * 12 * 30)) + (Convert.ToDecimal(rupeestxt.Text)));
            dbe.FDs.Add(farm);
            
            decimal amount = Convert.ToDecimal(rupeestxt.Text);
            decimal totalamount = Convert.ToDecimal(accounts.balance);
            decimal fdamount = totalamount - amount;
            accounts.balance = fdamount;
            dbe.SaveChanges();
            MessageBox.Show("fd started now");




        }
    }
}
