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
    public partial class passwordchange : Form
    {
        public passwordchange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankmanagement_dbEntities2 dbe = new bankmanagement_dbEntities2();
            if(oldpass.Text!=string.Empty || newpass.Text!=string.Empty)
            {
                Admin user1 = dbe.Admins.FirstOrDefault(a => a.username.Equals(usertxt.Text));
                if(user1!=null)
                {
                    if(user1.password.Equals(oldpass.Text))
                    {
                        user1.password = newpass.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("password changed");
                    }
                    else
                    {
                        MessageBox.Show("passwordincorrect");

                    }
                }

            }
        }

        private void oldpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
