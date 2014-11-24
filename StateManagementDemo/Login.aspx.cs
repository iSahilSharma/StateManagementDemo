using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["WrongAttempts"] = 0;
            }

            //Cookies - To track the Visitor History of the User
            HttpCookie cookie = Request.Cookies["VisitHistory"];

            if (cookie == null)
            {
                lblVisit.Text = "Welcome to Developer's Cafe";

                cookie = new HttpCookie("VisitHistory");
                cookie["VisitTime"] = DateTime.Now.ToString();
                cookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cookie);
            }
            else
            {
                lblVisit.Text = "Welcome to Developer's Cafe. You last visited on " + cookie["VisitTime"];
                cookie["VisitTime"] = DateTime.Now.ToString();
                cookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cookie);
            }



            //Application State - Count the number of Online Users.
            if (Application["Counter"] != null)
            {
                lblCounter.Text = Application["Counter"].ToString();
            }

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "admin" && txtPass.Text == "12345")
            {
                //Query String - To transfer information from one page to another by appending to the URL [Not Secure].
                //Response.Redirect(string.Format("Dashboard.aspx?username={0}", txtUser.Text));  

                //Session State - To transfer information from one page to another without appending to the URL [Secure].
                Session["Username"] = txtUser.Text;
                Response.Redirect("Dashboard.aspx");
            }

            else
            {
                //ViewState - To Count the Number of Wrong Login Attempts.
                if (ViewState["WrongAttempts"] != null)
                {
                    int count = Convert.ToInt32(ViewState["LoginAttempt"]) + 1;
                    lblAttempt.Text = "Incorrect Credentials. Number of Wrong Attempts are: " + count.ToString();

                    ViewState["LoginAttempt"] = count.ToString();
                }
            }

        }

    }
}