﻿using System;
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
                //The View State variable to hold down login attempts
                ViewState["LoginAttempt"] = 0;
            }

            //Creation for Persistent Cookie based on User's visit History
            HttpCookie cookie = Request.Cookies["Visit"];
            if (cookie == null)
            {
                lblMessage.Text = "First Time Visit";
            }
            else
            {
                lblMessage.Text = "Welcome " + cookie["Name"] + ". You last visited on " + cookie["VisitTime"];
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (ViewState["LoginAttempt"] != null)
            {
                int count = Convert.ToInt32(ViewState["LoginAttempt"]) + 1;
                lblAttempt.Text = count.ToString();

                ViewState["LoginAttempt"] = count.ToString();
            }


            //Retrieval of user history from cookie
            HttpCookie cookie = Request.Cookies["Visit"];
            if (cookie == null)
            {
                cookie = new HttpCookie("Visit");
            }

            cookie["Name"] = txtUsername.Text;
            cookie["VisitTime"] = DateTime.Now.ToString();
            cookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(cookie);
        }
    }
}