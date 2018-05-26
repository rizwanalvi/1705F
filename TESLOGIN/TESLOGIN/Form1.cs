using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TESLOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection _conn = new SqlConnection(@"Data Source=faculty18;Initial Catalog=1705Fdb;Integrated Security=True");
            _conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tLogin WHERE UNAME =@UNAME AND UPASS = @UPASS", _conn);
            cmd.Parameters.AddWithValue("@UNAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@UPASS", textBox2.Text);
            int _flag = int.Parse(cmd.ExecuteScalar().ToString());
            if (_flag > 0)
            {

                MessageBox.Show("Login");
                frmHome fm = new frmHome();
                fm.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("invalid");
            }
            _conn.Close();
        }
    }
}
