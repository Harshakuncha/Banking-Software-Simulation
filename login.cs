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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankmanagement_dbEntities2 db = new bankmanagement_dbEntities2();
            if (usertxt.Text != string.Empty || passtxt.Text != string.Empty)
            {
                var user1 = db.Admins.FirstOrDefault(a => a.username.Equals(usertxt.Text));
                if (user1 != null)
                {
                    if (user1.password.Equals(passtxt.Text))
                    {
                        {
                            menu obj = new menu();
                            this.Hide();
                            obj.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("password incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("please fill in details");
                }
            }
            else
            {
                MessageBox.Show("enter deatils");
            }
        }
    }
}
