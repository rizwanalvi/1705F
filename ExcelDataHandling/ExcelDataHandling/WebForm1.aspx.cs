using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace ExcelDataHandling
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    _sqlConn.Open();
                SqlCommand _cmd = new SqlCommand("select * from std",_sqlConn);
                GridView1.DataSource = _cmd.ExecuteReader();
                GridView1.DataBind();
                }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String path = Server.MapPath("~/UploadFile/" + FileUpload1.FileName);
            FileUpload1.SaveAs(path);
            string excelConnStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
            OleDbConnection _con = new OleDbConnection(excelConnStr);
            if(_con.State == System.Data.ConnectionState.Closed)
            _con.Open();
            OleDbCommand _cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", _con);
            OleDbDataReader dReader = _cmd.ExecuteReader();
            //GridView1.DataSource = dReader;
            //GridView1.DataBind();
            using (SqlConnection _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) {
                _sqlConn.Open();
                SqlBulkCopy _bulkCopy = new SqlBulkCopy(_sqlConn);
                _bulkCopy.DestinationTableName = "STD";
                _bulkCopy.ColumnMappings.Add("STD_NAME", "STD_NAME");
                _bulkCopy.WriteToServer(dReader);

            }





                if (_con.State == System.Data.ConnectionState.Open)
                    _con.Close();

        }
    }
}