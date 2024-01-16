using MySql.Data.MySqlClient;
using Synechron.EventsProtal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Synechron.EventsProtal.Dal
{
    public class SecurityDal
    {
        public User AuthenticateCredentials(User user)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEvntsConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = System.Data.CommandType.StoredProcedure;
                    CMD.CommandText = "AuthenticateCredentials";
                    CMD.Parameters.AddWithValue("P_Email", user.Email);
                    CMD.Parameters.AddWithValue("P_Password", user.Password);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DR.Read();
                    User existingUser = new User()
                    {
                        Email = Convert.ToString(DR["Email"]),
                        Role_Name = Convert.ToString(DR["RoleName"]),
                    };
                    DR.Close();
                    CN.Close();
                    return existingUser;
                }
            }
        }
    }
}