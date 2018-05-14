using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebHRM.Models;
namespace WebHRM
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = new LoginDb().GetLoginTable();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (new LoginDb().AddLoginInfo(new WebHRM.Models.Login { UNAME = TextBox1.Text, UPASS = TextBox2.Text, ROLEID =DropDownList1.SelectedValue.ToString() }) > 0) {

                Response.Write("Hmhahha Data insert ho gaya");
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (new LoginDb().UserAuthentication(Login1.UserName,Login1.Password)) {
                Login1.FailureText = "Ok";
                Response.Redirect("~/MoviesDetails.aspx");
            }
            else
            {
                Login1.FailureText = "Invalid User";

            }
        }
    }
}