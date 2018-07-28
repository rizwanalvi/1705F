using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApprEVISION
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=testdb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO PRODUCT VALUES(@PRONAME,@PIC)", _sqlconn);
            _cmd.Parameters.AddWithValue("@PRONAME", TextBox1.Text);
            _cmd.Parameters.AddWithValue("@PIC", FileUpload1.FileBytes);
            _cmd.ExecuteNonQuery();

            _sqlconn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=testdb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlconn.Open();
            int ID = 1;
            SqlCommand _cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE ID = @ID", _sqlconn);
            _cmd.Parameters.AddWithValue("@ID",ID);
           SqlDataReader dReader =  _cmd.ExecuteReader();
            dReader.Read();
          byte[] _img = (byte[])  dReader["PIC"];
           String sImg = Convert.ToBase64String(_img);
            Image1.ImageUrl ="data:image/png;base64," + sImg;
            _sqlconn.Close();

        }
    }
}