using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace PROGPOE_ST10090287.Classes
{
    public static class Connection
    {
        public static SqlConnection GetConnection()
        {
            string fileName = "PROGDB.mdf";
            string filePath = Path.GetFullPath(fileName).Replace(@"\bin\Debug", @"\Data");
            string strCon = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DISD3\Desktop\PROGPOE_ST10090287\PROGPOE_ST10090287\PROGPOE_ST10090287\App_Data\PROGDB.mdf;Integrated Security=True";
            return new SqlConnection(strCon);
        }

    }
}
