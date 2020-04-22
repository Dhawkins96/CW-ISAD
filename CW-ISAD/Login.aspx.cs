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
    public partial class Login : System.Web.UI.Page
    {
        string connectionString = "SERVER=" + DBcon.SERVER + ";" +
        "DATABASE=" + DBcon.DATABASE_NAME + ";" + "UID=" +
        DBcon.USER_NAME + ";" + "PASSWORD=" +
        DBcon.PASSWORD + ";" + "SslMode=" +
        DBcon.SslMode + ";";
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            int userNum = Convert.ToInt32(txtUser.Text);

            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                string query = "select * from isad157_DHawkins.user where userID=" + userNum;

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable usersDataTable = new DataTable();
                sqlDA.Fill(usersDataTable);
                userGV.DataSource = usersDataTable;
                userGV.DataBind();

                if (userNum <= 5000)
                {
                      Session["UserID"] = txtUser.Text;
                      Response.Redirect("UserProfile.aspx");
                }
                else
                {
                    Response.Write("<script>alert('User ID entered incorrectly')</script>");
                }
            }
        }
    }
}
