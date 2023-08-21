using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PROGPOE_ST10090287.Classes
{
    class jaredlib
    {
        SqlConnection conn = Connection.GetConnection();
        //Create a list
        public static List<jaredlib> ProgramList = new List<jaredlib>();

        public string ModuleC { get; set; }
        public string _ModuleN
        {
            get { return ModuleC; }
            set
            {
                if (value.Trim().Length < 3)
                {
                    throw new Exception($"Module Name ({value}) should at least be 3 characters long");
                }
                _ModuleN = value;
            }
        }
        private string ModuleN { get; set; }
        public int Credits { get; set; }
        public int hours { get; set; }
        public string ModuleStartDate { get; set; }
        public int weeks { get; set; }
        public int after { get; set; }
        public int study { get; set; }

        //Default constructor
        public jaredlib()
        {

        }
        public jaredlib(string ModuleCode, string ModuleName, int ModuleCredits, int ModuleHours, string startDate, int Weeks)
        {
            ModuleC = ModuleCode;
            ModuleN = ModuleName;
            Credits = ModuleCredits;
            hours = ModuleHours;
            ModuleStartDate = startDate;
            weeks = Weeks;

        }
        public void SelfStudyCalculation()
        {
            study = ((Credits * 10) / weeks) - hours;
        }

        public void RemainderCalculation()
        {
            after = hours - study;
        }
        public override string ToString()
        {

            //Code: PROG6212 NAME: Programming 2B Credits: 15 Hours: 5
            return $"Module Code: {ModuleC} Module Name: {ModuleN} Module Credits: {Credits} Module Hours: {hours} Module Start Date: {ModuleStartDate} Module Weeks: {weeks} Self Study Hours: {study} Self Study Remainder: {after}";

        }

        //Implementing indexer that will return a specific code
        public jaredlib this[string code]
        {
            get
            {
                return ProgramList.Find(x => x.ModuleC.Equals(code));
            }

        }
        public jaredlib SelfStudyHours()
        {
            string strSelect = $"SELECT * FROM tblModules WHERE SelfStudy = (SELECT SelfStudy FROM tblModules)";
            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ModuleC = (string)reader[0];
                            ModuleN = (string)reader[1];
                            Credits = Convert.ToInt32(reader[2]);
                            hours = Convert.ToInt32(reader[3]);
                            ModuleStartDate = (string)reader[4];
                            weeks = Convert.ToInt32(reader[5]);
                            study = Convert.ToInt32(reader[5]);
                            after = Convert.ToInt32(reader[6]);
                        }
                    }
                }
            }
            return new jaredlib(ModuleC, ModuleN, Credits, hours, ModuleStartDate, weeks);
        }
        public jaredlib RemainderHours()
        {
            string strSelect = $"SELECT * FROM Modules WHERE Remainder = (SELECT Remainder FROM tblModules)";
            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ModuleC = (string)reader[0];
                            ModuleN = (string)reader[1];
                            Credits = Convert.ToInt32(reader[2]);
                            hours = Convert.ToInt32(reader[3]);
                            ModuleStartDate = (string)reader[4];
                            weeks = Convert.ToInt32(reader[5]);
                            study = Convert.ToInt32(reader[5]);
                            after = Convert.ToInt32(reader[6]);
                        }
                    }
                }
            }
            return new jaredlib(ModuleC, ModuleN, Credits, hours, ModuleStartDate, weeks);
        }
        public void AddModules()
        {
            string strInsert = $"INSERT INTO Modules VALUES('{ModuleC}','{ModuleN}','{Credits}','{hours}','{ModuleStartDate}','{weeks}','{study}','{after}','{User.UserName}')";
            SqlCommand cmdInsert = new SqlCommand(strInsert, conn);

            conn.Open();
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public List<jaredlib> AllModules()
        {
            string strSelect = $"SELECT * FROM Modules";
            SqlCommand cmdSelect = new SqlCommand(strSelect, conn);
            DataTable myTable = new DataTable();
            DataRow myRow;
            SqlDataAdapter myAdapter = new SqlDataAdapter(cmdSelect);
            List<jaredlib> _list = new List<jaredlib>();

            conn.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];
                    ModuleC = (string)myRow[0];
                    ModuleN = (string)myRow[1];
                    Credits = Convert.ToInt32(myRow[2]);
                    hours = Convert.ToInt32(myRow[3]);
                    ModuleStartDate = (string)myRow[4];
                    weeks = Convert.ToInt32(myRow[5]);


                    _list.Add(new jaredlib(ModuleC,  ModuleN, Credits, hours, ModuleStartDate, weeks));
                }
            }

            conn.Close();
            return _list;
        }
    }
}