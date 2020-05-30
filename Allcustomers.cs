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
    public partial class Allcustomers : Form
    {
        public Allcustomers()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            //throw new NotImplementedException();
            dataGridView1.AutoGenerateColumns = false;
            bankmanagement_dbEntities2 bmd = new bankmanagement_dbEntities2();
            var items = bmd.userAccounts.ToList();
            dataGridView1.DataSource = items;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
