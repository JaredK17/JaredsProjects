using PROGPOE_ST10090287.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE_ST10090287
{
    public partial class MANAGEMODULES : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }





        protected void Button2_Click(object sender, EventArgs e)
        {
            //Declartions
            string Mcode, Mname;
            string startdate;
            int credit, eweeks, hours;

            //Assigning declarations to the text boxes for the user to enter
            Mname = MNAME.Text;
            Mcode = MCODE.Text;
            startdate = DT.Text;
            credit = Convert.ToInt32(CRED.Text);
            eweeks = Convert.ToInt32(WK.Text);
            hours = Convert.ToInt32(HR.Text);

            //Declaring an object of type Libary
            jaredlib program = new jaredlib(Mcode, Mname, credit, hours, startdate, eweeks);

            //Call from liabrary class
            List<jaredlib> List = jaredlib.ProgramList;
            try
            {
                jaredlib display = new jaredlib(Mcode, Mname, credit, hours, startdate, eweeks);
                jaredlib.ProgramList.Add(display);

                display.SelfStudyCalculation();
                display.RemainderCalculation();

                Response.Write(display.ToString());
                display.AddModules();
                Response.Write($"Module {program.ModuleC} has been added");

            }
            catch (Exception x)
            {
                Response.Write(x.Message);
             }
        }
    }
}