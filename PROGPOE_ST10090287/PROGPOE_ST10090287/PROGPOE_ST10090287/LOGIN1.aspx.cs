using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROGPOE_ST10090287.Classes;

namespace PROGPOE_ST10090287
{
    public partial class LOGIN1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            string usName = userbox.Text.ToString();
            string password = passwordbox.Text.ToString();
            User user = new User();
            user.getUser(usName);

        

            if (usName.Equals((usName)))
            {
                Response.Redirect("MANAGEMODULES.aspx");
            }
            else
            {
                Response.Write("Incorrect information entered. please try again");
                Response.Write("Register again");
            
            }
        }
    }
}