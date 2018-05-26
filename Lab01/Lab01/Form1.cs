using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ImageConverter converter = new ImageConverter();
            byte[] imgData = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO PRODUCT(POSTER) VALUES(@POSTER)", _sqlConn);
            _cmd.Parameters.AddWithValue("@POSTER",imgData);
            _cmd.ExecuteNonQuery();
             }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            openFileDialog1.ShowDialog();
            
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
           
        }

        private void Show_Click(object sender, EventArgs e)
        {
            ImageConverter converter = new ImageConverter();
            byte[] imgData;
            SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=Inventorydb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT poster FROM PRODUCT WHERE ID = @ID", _sqlConn);
            _cmd.Parameters.AddWithValue("@ID", 1);
             imgData = (byte[]) _cmd.ExecuteScalar();
            MemoryStream ms = new MemoryStream(imgData);
            pictureBox2.Image = Image.FromStream(ms);
            
        }
    }
}
