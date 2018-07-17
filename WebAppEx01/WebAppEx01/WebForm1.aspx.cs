using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppEx01.Models;
namespace WebAppEx01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();

        }
       
        public void LoadGridView() {

            Student std = new Student();
            GridView1.DataSource = std.getAllStudents();
            GridView1.DataBind();
        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGridView();
        }

        protected void OnUpdate(object sender, EventArgs e)
        {
            LinkButton btnUpdate = (LinkButton) sender;
            GridViewRow dRow = (GridViewRow) btnUpdate.NamingContainer;
          TextBox tb =  dRow.Cells[1].Controls[0] as TextBox;
            String data = tb.Text;
        }

        protected void OnCancel(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadGridView();
        }
    }
}