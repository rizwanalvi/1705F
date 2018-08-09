using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace WebAppRep
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                DataBinder();
            }

        }
        public void DataBinder() {
            SqlConnection _Conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM CUSTOMERS",_Conn);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            Repeater1.DataSource = dTable;
            Repeater1.DataBind();


        }

        protected void OnEditing(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            item.FindControl("LinkButton4").Visible = true;
            item.FindControl("LinkButton1").Visible = false;
            item.FindControl("LinkButton2").Visible = false;
            item.FindControl("LinkButton3").Visible = true;
            item.FindControl("TextBox1").Visible = true;
            item.FindControl("TextBox2").Visible = true;
            item.FindControl("Label1").Visible = false;
            item.FindControl("Label2").Visible = false;
            item.FindControl("DropDownList1").Visible = true;

        }

        protected void OnDeleting(object sender, EventArgs e)
        {

        }

        protected void OnCancel(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            item.FindControl("LinkButton4").Visible = false;
            item.FindControl("LinkButton2").Visible = true;
            item.FindControl("LinkButton1").Visible = true;
            item.FindControl("LinkButton3").Visible = false;
            item.FindControl("TextBox1").Visible = false;
            item.FindControl("TextBox2").Visible = false;
            item.FindControl("Label1").Visible = true;
            item.FindControl("Label2").Visible = true;
            item.FindControl("DropDownList1").Visible = false;
        }

       

        protected void OnUpdating(object sender, EventArgs e)
        {
           // Label3
               RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            TextBox txtName = (TextBox)item.FindControl("TextBox1");
            TextBox txtCountry = (TextBox)item.FindControl("TextBox2");
            DropDownList lstCounties = item.FindControl("DropDownList1") as DropDownList;
            String _Name = txtName.Text;
            String _Country = txtCountry.Text;
            Label lbId = item.FindControl("Label3") as Label;
            SqlConnection _Conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _Conn.Open();
            SqlCommand _cmd = new SqlCommand("UPDATE CUSTOMERS SET NAME =@NAME,COUNTRY=@COUNTRY WHERE CustomerId = @ID", _Conn);
            _cmd.Parameters.AddWithValue("@NAME",_Name);
            _cmd.Parameters.AddWithValue("@COUNTRY", lstCounties.SelectedItem.Value);
            _cmd.Parameters.AddWithValue("@ID", lbId.Text);
            _cmd.ExecuteNonQuery();

            DataBinder();
        }
    }
}