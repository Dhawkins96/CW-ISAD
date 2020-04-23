using System;
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
    public partial class UserProfile : System.Web.UI.Page
    {
        string connectionString = "SERVER=" + DBcon.SERVER + ";" +
        "DATABASE=" + DBcon.DATABASE_NAME + ";" + "UID=" +
        DBcon.USER_NAME + ";" + "PASSWORD=" +
        DBcon.PASSWORD + ";" + "SslMode=" +
        DBcon.SslMode + ";";

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Currently Logged User is - " + Convert.ToInt32(Session["UserID"]);

            using (MySqlConnection connection =
              new MySqlConnection(connectionString))
            {
                string query = "select * from isad157_DHawkins.user where userID=" + Session["UserID"].ToString();

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable userTable = new DataTable();
                sqlDA.Fill(userTable);

                gridview.DataSource = userTable;
                gridview.DataBind();
            }
        }
    }
}