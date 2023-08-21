using PROGPOE_ST10090287.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE_ST10090287
{
    public partial class SEARCH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button122_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand($"Select * FROM Modules WHERE ModuleC={ModuleS.Text}", conn);
            cmd1.Parameters.AddWithValue("ModuleCode", ModuleS.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            try
            {
                if (reader1.Read())
                {


                    searchlist.Items.Add("Module Code IS: \t" + reader1["ModuleC"].ToString());
                    searchlist.Items.Add("Module name" + reader1["ModuleN"].ToString());
                    searchlist.Items.Add("Module Credit: \t" + reader1["Credits"].ToString());
                    searchlist.Items.Add("Module Hours : \t" + reader1["hours"].ToString());
                    searchlist.Items.Add("Module StatDate : \t" + reader1["startdate"].ToString());
                    searchlist.Items.Add("Module Weeks: \t" + reader1["weeks"].ToString());
                    searchlist.Items.Add("Module SelfStudy: \t" + reader1["Study"].ToString());
                    searchlist.Items.Add("Module Remainder : \t" + reader1["after"].ToString());
                    searchlist.Items.Add("Username: \t" + reader1["Username"].ToString());
                }
            }
            catch (Exception error)
            {
                Response.Write(error.Message);
            }

        }
    }
}