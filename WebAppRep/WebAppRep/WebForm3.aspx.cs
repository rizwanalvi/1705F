using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppRep
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { if(!IsPostBack)
            DataBinder();
        }
        public void DataBinder()
        {
            SqlConnection _Conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM CUSTOMERS", _Conn);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            Repeater1.DataSource = dTable;
            Repeater1.DataBind();


        }

        protected void OnEditing(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            item.FindControl("LinkButton3").Visible = true;
            item.FindControl("LinkButton4").Visible = true;
            item.FindControl("LinkButton1").Visible = false;
            item.FindControl("LinkButton2").Visible = false;
            item.FindControl("Label2").Visible = false;
            item.FindControl("Label3").Visible = false;
            item.FindControl("TextBox1").Visible = true;
            item.FindControl("TextBox2").Visible = true;
        }

        protected void OnDeleting(object sender, EventArgs e)
        {

        }

        protected void OnUpdating(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            item.FindControl("LinkButton3").Visible = false;
            item.FindControl("LinkButton4").Visible = false;
            item.FindControl("LinkButton1").Visible = true;
            item.FindControl("LinkButton2").Visible = true;
            item.FindControl("Label2").Visible = true;
            item.FindControl("Label3").Visible = true;
            item.FindControl("TextBox1").Visible = false;
            item.FindControl("TextBox2").Visible = false;
            TextBox txtName = item.FindControl("TextBox1") as TextBox;
            TextBox txtCountry = item.FindControl("TextBox2") as TextBox;
            Label txtId = item.FindControl("Label1") as Label;
           

        }

        protected void OnCanceled(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            item.FindControl("LinkButton3").Visible = false;
            item.FindControl("LinkButton4").Visible = false;
            item.FindControl("LinkButton1").Visible = true;
            item.FindControl("LinkButton2").Visible = true;
            item.FindControl("Label2").Visible = true;
            item.FindControl("TextBox1").Visible = false;
            item.FindControl("Label3").Visible = true;
            item.FindControl("TextBox2").Visible = false;
        }
    }
}