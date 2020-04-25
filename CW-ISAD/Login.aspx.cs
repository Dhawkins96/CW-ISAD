﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CW_ISAD
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrEmpty(txtUser.Text))
            {
                Response.Write("<script>alert('Please enter your User ID')</script>");
            }
            else if (Convert.ToInt32(txtUser.Text) <= 5000)
            {
                Session["UserID"] = txtUser.Text;
                Response.Redirect("UserProfile.aspx");
            }
            else
            {
                Response.Write("<script>alert('User ID NOT FOUND')</script>");
            }
        }
    }
}
    
