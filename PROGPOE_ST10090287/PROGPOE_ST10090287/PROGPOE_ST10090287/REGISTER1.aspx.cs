using PROGPOE_ST10090287.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE_ST10090287
{
    public partial class REGISTER1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

            
        }
        protected void registerBtn_click (object sender  , EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Username = USERNAME.Text.ToString();
            String password = PASSWORD.Text.ToString();
            User jared = new User(Username, password);
            jared.hashPassword(password);
            jared.Register();
            Response.Write($"Users{Username} has been added successfully");
            Login log = new Login();
            Response.Redirect("LOGIN1.aspx");
        }
    }
}