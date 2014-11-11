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
            //[Query String] - Retrieval of Username using Query String
            //lblUserInfo.Text = Request.QueryString["Username"];


            //[Session State] - Retrieval of Username using Session State
            lblUserInfo.Text = Session["Username"].ToString();
        }
    }
}