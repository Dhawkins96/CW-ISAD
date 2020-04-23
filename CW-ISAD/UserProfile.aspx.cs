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

            if (!Page.IsPostBack)
            {
                getData();
                getFriends();
            }

        }

        private void getData() 
        {
            using (MySqlConnection connection =
              new MySqlConnection(connectionString))
            {
                connection.Open();

                //Gets User information from User table
                MySqlCommand cmd = new MySqlCommand("select * from isad157_DHawkins.user where userID=" + Session["UserID"].ToString(), connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable userTable = new DataTable();
                sqlDA.Fill(userTable);

                if (userTable.Rows.Count > 0)
                {
                    lblFirstName.Text = userTable.Rows[0]["FirstName"].ToString();
                    lblLastName.Text = userTable.Rows[0]["LastName"].ToString();
                    lblGender.Text = userTable.Rows[0]["Gender"].ToString();
                    lblHometown.Text = userTable.Rows[0]["Hometown"].ToString();
                    lblCity.Text = userTable.Rows[0]["City"].ToString();
                    lblRelation.Text = userTable.Rows[0]["RelationStatus"].ToString();
                }


                //Gets Education information from Education Table
                MySqlCommand eduCmd = new MySqlCommand("select * from isad157_DHawkins.education where userID_edu=" + Session["UserID"].ToString(), connection);
                MySqlDataAdapter DA = new MySqlDataAdapter(eduCmd);
                DataTable eduTable = new DataTable();
                DA.Fill(eduTable);

                if (eduTable.Rows.Count > 0)
                {
                    lblEduName.Text = eduTable.Rows[0]["EduName"].ToString();
                    lblEduDate.Text = eduTable.Rows[0]["EduDate"].ToString();
                }

                //Gets Work information from Workplace Table
                MySqlCommand workCmd = new MySqlCommand("select * from isad157_DHawkins.workplace where userID_work=" + Session["UserID"].ToString(), connection);
                MySqlDataAdapter Work = new MySqlDataAdapter(workCmd);
                DataTable workTable = new DataTable();
                Work.Fill(workTable);

                if (eduTable.Rows.Count > 0)
                {
                    lblWorkName.Text = workTable.Rows[0]["WorkName"].ToString();
                    lblWorkDate.Text = workTable.Rows[0]["WorkDate"].ToString();
                }
            }
        }

        private void getFriends()
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                connection.Open();

                //Gets User information from User table
                //"SELECT FirstName, LastName from user inner join user_friendship on userID = " + Session["UserID"].ToString() + " " + "WHERE userID = FriendID";
                string query = "SELECT FirstName, LastName from user inner join friendship on userID_fri = " + Session["UserID"].ToString() + " WHERE friendid = userid";
                MySqlCommand fricmd = new MySqlCommand (query, connection);
                MySqlDataAdapter frisqlDA = new MySqlDataAdapter(fricmd);
                DataTable friuserTable = new DataTable();
                frisqlDA.Fill(friuserTable);

                friends.DataSource = friuserTable;
                friends.DataBind();
            }
        }
    }
}
