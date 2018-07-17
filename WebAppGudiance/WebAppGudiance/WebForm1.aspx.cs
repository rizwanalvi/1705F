using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace WebAppGudiance
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String strConn = ConfigurationManager.ConnectionStrings["dbGuide"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection _conn = new SqlConnection(strConn);
            _conn.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _conn;
            _cmd.CommandText = "SELECT DISTINCT(PROG_NAME) FROM UN_PROGRAMS";
            DropDownList1.DataSource = _cmd.ExecuteReader();
            DropDownList1.DataTextField = "PROG_NAME";
            DropDownList1.DataValueField = "PROG_NAME";
            DropDownList1.DataBind();
            _conn.Close();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection _conn = new SqlConnection(strConn);
            _conn.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _conn;
            _cmd.CommandText = @"SELECT uL.UN_ID,UL.UN_NAME,UP.PROG_NAME,UP.ADM_PERCENT FROM UN_LIST ul
  INNER JOIN UN_PROGRAMS up
  ON ul.UN_ID = up.UN_ID
  WHERE PROG_NAME = @PROG_NAME";

            _cmd.Parameters.AddWithValue("@PROG_NAME",DropDownList1.SelectedItem.ToString());

            GridView1.DataSource = _cmd.ExecuteReader();
            GridView1.DataBind();
            _conn.Close();




        }
    }
}