using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE_ST10090287
{
    public partial class Reminder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void RemiderStore(string cString, string Modulecode, DateTime DateCal)
        {

            string query = "INSERT INTO dbo.reminder(ModuleC,Date)" +
                "Values (@ModuleC,@Date)";

            using (SqlConnection cn = new SqlConnection(cString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@ModuleC", System.Data.SqlDbType.VarChar).Value = Modulecode;

                cmd.Parameters.Add("@Date", System.Data.SqlDbType.DateTime).Value = DateCal;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            string ModuleCode = Rtxt.Text;
            DateTime cal = reminderCal.SelectedDate;


            string cString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DISD3\Desktop\PROGPOE_ST10090287\PROGPOE_ST10090287\PROGPOE_ST10090287\App_Data\PROGDB.mdf;Integrated Security=True";
            RemiderStore(cString, ModuleCode, cal);
            Response.Write("SUCCESSFULLY SET A REMINDER FOR YOU");
        }
    }
}