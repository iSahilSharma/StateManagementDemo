using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Query String - Retrieval of username from Query String.
            // lblName.Text = Request.QueryString["username"];

            //Session State - Retrieval of username from Session Variable.
            lblName.Text = Session["Username"].ToString();

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            //Response.Redirect("Login.aspx");
        }
    }
}