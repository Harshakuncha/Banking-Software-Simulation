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
    public partial class viewfd : Form
    {
        BindingList<FD> b1;
        bankmanagement_dbEntities2 dbe;
        public viewfd()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            b1 = new BindingList<FD>();
            dbe = new bankmanagement_dbEntities2();
            String date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            MessageBox.Show(date);
            var item = dbe.FDs.Where(a => a.start_date.Equals(date));
            dataGridView1.DataSource = item.ToList();





        }
    }
}
