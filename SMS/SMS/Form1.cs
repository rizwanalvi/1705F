using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Form1 : Form
    {
        Logindb ldb = null;
        public Form1()
        {
            InitializeComponent();
            ldb = new Logindb();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ldb.GetLoginTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ldb.AddData(new Login { ID = int.Parse(textBox1.Text), UNAME = textBox2.Text, UPASS = textBox3.Text, ROLEID = int.Parse(textBox4.Text) });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ldb.DeleteData(int.Parse(textBox1.Text));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ldb.UpdateData(new Login { ID = int.Parse(textBox1.Text), UNAME = textBox2.Text, UPASS = textBox3.Text, ROLEID = int.Parse(textBox4.Text) });
        }

      
    }
}
