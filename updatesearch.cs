using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bankmanagementmainapplication
{
    public partial class updatesearch : Form
    {

        bankmanagement_dbEntities2 bs;
        MemoryStream ms;
        BindingList<userAccount> b1;



        public updatesearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            b1 = new BindingList<userAccount>();
            bs = new bankmanagement_dbEntities2();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            var items = bs.userAccounts.Where(a => a.Account_no == accno);
            foreach(var item1 in items)
            {
                b1.Add(item1);
            }
            dataGridView1.DataSource = b1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            b1 = new BindingList<userAccount>();
            bs = new bankmanagement_dbEntities2();
            var items = bs.userAccounts.Where(a => a.Name == nametxt.Text);
            foreach(var item1 in items)
            {
                b1.Add(item1);
            }
            dataGridView1.DataSource = b1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bs = new bankmanagement_dbEntities2();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = bs.userAccounts.Where(a => a.Account_no == accno).FirstOrDefault();
            accnotxt.Text = item.Account_no.ToString();
            nametxt.Text = item.Name;
            mothertxt.Text = item.mothername;
            fathertxt.Text = item.fathername;
            phonetxt.Text = item.Phoneno;
            addresstxt.Text = item.Address;
            byte[] img = item.picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            distxt.Text = item.District;
            statetxt.Text = item.state;
            if(item.Gender=="male")
            {
                maleradio.Checked = true;

            }
            else if(item.Gender=="female")
            {
                femaleradio.Checked = true;

            }
            if(item.m_status=="married")
            {
                marriedradio.Checked = true;

            }
               
            else if(item.m_status=="single")
            {
                singleradio.Checked = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(op.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            b1.RemoveAt(dataGridView1.SelectedRows[0].Index);
            bs = new bankmanagement_dbEntities2();
            decimal a = Convert.ToDecimal(accnotxt.Text);
            userAccount acc = bs.userAccounts.First(s => s.Account_no.Equals(a));
            bs.userAccounts.Remove(acc);
            bs.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs = new bankmanagement_dbEntities2();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            userAccount us = bs.userAccounts.First(s => s.Account_no.Equals(accnotxt));
            us.Account_no = Convert.ToDecimal(accnotxt.Text);
            us.Name = nametxt.Text;
            us.Date = dateTimePicker1.Value.ToString();
            us.mothername = mothertxt.Text;
            us.fathername = fathertxt.Text;
            us.Phoneno = phonetxt.Text;
            if (maleradio.Checked == true)
            {
                us.Gender = "male";
            }
            else if (femaleradio.Checked == true)
            {
                us.Gender = "female";


            }
            if (marriedradio.Checked == true)
            {
                us.m_status = "married";

            }
            else if (singleradio.Checked == true)
            {
                us.m_status = "single";

            }
            Image img = pictureBox1.Image;
            if (img.RawFormat != null)
            {
                if (ms != null)
                {
                    img.Save(ms, img.RawFormat);
                    us.picture = ms.ToArray();

                }
            }
            us.Address = addresstxt.Text;
            us.District = distxt.Text;
            us.state = statetxt.Text;
            bs.SaveChanges();
            MessageBox.Show("record updated");

        }

        private void updatesearch_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
