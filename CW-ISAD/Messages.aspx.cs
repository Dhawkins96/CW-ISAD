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
    public partial class Messages : System.Web.UI.Page
    {
        string connectionString = "SERVER=" + DBcon.SERVER + ";" +
        "DATABASE=" + DBcon.DATABASE_NAME + ";" + "UID=" +
        DBcon.USER_NAME + ";" + "PASSWORD=" +
        DBcon.PASSWORD + ";" + "SslMode=" +
        DBcon.SslMode + ";";

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Currently Logged User is - " + Convert.ToInt32(Session["UserID"]);
        }
        //private void getMessages()
        //{
        //    using (MySqlConnection connection =
        //        new MySqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        //Gets Friend information from Friendship table and joins with UserID to grab their full name
        //        string query = "SELECT FirstName, LastName from user AND select DateTime, Text from messages inner join messages on userID_mess = " + Session["UserID"].ToString() + " WHERE friendid_mess = userid";
        //        MySqlCommand fricmd = new MySqlCommand(query, connection);
        //        MySqlDataAdapter frisqlDA = new MySqlDataAdapter(fricmd);
        //        DataTable friuserTable = new DataTable();
        //        frisqlDA.Fill(friuserTable);

        //        MessagesGV.DataSource = friuserTable;
        //        MessagesGV.DataBind();
        //    }
        //}
    }
}