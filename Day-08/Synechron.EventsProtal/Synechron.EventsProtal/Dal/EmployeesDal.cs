using Synechron.EventsProtal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Synechron.EventsProtal.Dal
{
    public class EmployeesDal
    {
        public List<Employee> GetAllEmployees()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEventsConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllEmployees";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Employee> employees = new List<Employee>();
                    while (DR.Read())
                    {
                        employees.Add(new Employee()
                        {
                            Employee_ID = Convert.ToInt32(DR["Employee_ID"]),
                            Employee_Name = Convert.ToString(DR["Employee_Name"]),
                            City = Convert.ToString(DR["City"]),
                            Email = Convert.ToString(DR["Email"]),
                            Phone_Number = Convert.ToString(DR["Phone_Number"]),
                        });
                    }
                    DR.Close();
                    CN.Close();
                    return employees;
                }
            }
        }
        public Employee GetEmployeeDetails(int employeeID)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEventsConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllEmployees";
                    CMD.Parameters.AddWithValue("p_EmployeeId", employeeID);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DR.Read();
                    Employee employee = new Employee()
                    {
                        Employee_ID = Convert.ToInt32(DR["Employee_ID"]),
                        Employee_Name = Convert.ToString(DR["Employee_Name"]),
                        Address = Convert.ToString(DR["Address"]),
                        City = Convert.ToString(DR["City"]),
                        Country = Convert.ToString(DR["Country"]),
                        Phone_Number = Convert.ToString(DR["Phone_Number"]),
                        Email = Convert.ToString(DR["Email"]),
                        Skill_Sets = Convert.ToString(DR["Skill_Sets"]),
                        Avatar = Convert.ToString(DR["Avatar"]),
                        ZipCode = Convert.ToString(DR["ZipCode"])
                    };
                    DR.Close();
                    CN.Close();
                    return employee;
                }
            }
        }
        public int InsertEmployees(Employee employee)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEventConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertEmployees";
                    CMD.Parameters.AddWithValue("P_Employee_Name", employee.Employee_Name);
                    CMD.Parameters.AddWithValue("P_Address", employee.Address);
                    CMD.Parameters.AddWithValue("P_City", employee.City);
                    CMD.Parameters.AddWithValue("P_Country", employee.Country);
                    CMD.Parameters.AddWithValue("P_Phone_Number", employee.Phone_Number);
                    CMD.Parameters.AddWithValue("P_Email", employee.Email);
                    CMD.Parameters.AddWithValue("P_Skill_Sets", employee.Skill_Sets);
                    CMD.Parameters.AddWithValue("P_Avatar", employee.Avatar);
                    CMD.Parameters.AddWithValue("P_ZipCode", employee.ZipCode);
                    int result = CMD.ExecuteNonQuery();
                    CN.Close();
                    return result;
                }
            }
        }
    }
}