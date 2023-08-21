using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PROGPOE_ST10090287.Classes
{
    public class User
    {
        SqlConnection connect = Connection.GetConnection();
        public static string UserName { get; set; }
        public static string UserPassword { get; set; }
        public User()
        {

        }
        public User(string uName, String uPassword)
        {
            UserName = uName;
            UserPassword = uPassword;
        }
        public void getUser(string usName)
        {
            string sqlSelect = $"SELECT * FROM User1 WHERE UserName = '{usName}'";
            using (connect)
            {
                SqlCommand cmdselect = new SqlCommand(sqlSelect, connect);

                connect.Open();
                using (SqlDataReader reader = cmdselect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserName = (string)reader[0];
                        UserPassword = (string)reader[1];
                    }
                }
            }

        }
        public void Register()
        {
            
            string Insert = $"INSERT INTO User1 VALUES ('{UserName}','{UserPassword}')";
            SqlCommand cmIns = new SqlCommand(Insert, connect);

            connect.Open();
            cmIns.ExecuteNonQuery();
           
        }
        public string hashPassword(string UserPassword)
        {
            SHA1CryptoServiceProvider hash = new SHA1CryptoServiceProvider();

            //get the byte representing of the password
            byte[] passwordBytes = Encoding.ASCII.GetBytes(UserPassword);

            //returning the hash encrypted password
            byte[] encryptedBytes = hash.ComputeHash(passwordBytes);

            //returning thhe string
            return Convert.ToBase64String(encryptedBytes);

        }
    }
}

