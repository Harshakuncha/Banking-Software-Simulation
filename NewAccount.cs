using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankmanagementmainapplication
{
    public partial class NewAccount : Form
    {
        String gender = string.Empty;
        String m_status = string.Empty;
        decimal no;
        bankmanagement_dbEntities2 bmd;
        MemoryStream ms;

      



        public NewAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();

        }

        private void loadstate()
        {
            // throw new NotImplementedException();
            comboBox1.Items.Add("madhyapradesh");
            comboBox1.Items.Add("rajasthan");
        }

        private void loadaccount()
        {
            bmd = new bankmanagement_dbEntities2();
         var obj = bmd.userAccounts.ToArray();
          no = obj.LastOrDefault().Account_no + 1;
          accnotxt.Text = Convert.ToString(no);




        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelal.Text = DateTime.Now.ToString("MM/dd/yyyy");


            
        }

        private void accnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void datelal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(maleradio.Checked)
            {
                gender = "male";

            }
            else if(femaleradio.Checked)
            {
                gender = "female";

            }
            if(marriedradio.Checked)
            {
                 m_status= "married";

            }
            else if(singleradio.Checked)
            {
                m_status = "single";
            }
            bmd = new bankmanagement_dbEntities2();
            userAccount acc = new userAccount();
            acc.Account_no = Convert.ToDecimal(accnotxt.Text);
            acc.Name = nametxt.Text;
            acc.Dob = dateTimePicker1.Value.ToString();
            acc.Phoneno = phonetxt.Text;
            acc.Address = addresstxt.Text;
            acc.District = disttxt.Text;
            acc.state = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.m_status = m_status;
            acc.fathername = fathertxt.Text;
            acc.mothername = mothertxt.Text;
            acc.balance =Convert.ToDecimal( balancetxt.Text);
            acc.Date = datelal.Text;
            acc.picture = ms.ToArray();
            _ = bmd.userAccounts.Add(acc);
            _ = bmd.SaveChanges();
            _ = MessageBox.Show("succesfull");
            this.Hide();






        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);

            }
        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
