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
    public partial class menu : Form
    {
        private const DockStyle fill = DockStyle.Fill;

        public menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewAccount newac = new NewAccount();
            newac.MdiParent = this;
            newac.Dock = fill;
            newac.Show();
        }

        private void updatesearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatesearch us = new updatesearch();
            us.MdiParent = this;
            us.Dock = fill;
            us.Show();




        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Allcustomers ac = new Allcustomers();
            ac.MdiParent = this;
            ac.Dock = fill;
            ac.Show();

        
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credit cs = new credit();
            cs.MdiParent = this;
            cs.Dock = fill;
            cs.Show();


        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {

            withdraw wd = new withdraw();
            wd.MdiParent = this;
            wd.Dock = fill;
            wd.Show();

        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transferform tf = new transferform();
            tf.MdiParent = this;
            tf.Dock = fill;
            tf.Show();

        }

        private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixeddeposit f = new fixeddeposit();
            f.MdiParent = this;
            f.Dock = fill;
            f.Show();

            
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balancesheet bs = new balancesheet();
            bs.MdiParent = this;
            bs.Dock = fill;
            bs.Show();
        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewfd vf = new viewfd();
            vf.MdiParent = this;
            vf.Dock = fill;
            vf.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login l = new login();
            l.Show();
        }

       

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordchange pc = new passwordchange();
            this.Hide();

            pc.Show();


        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
