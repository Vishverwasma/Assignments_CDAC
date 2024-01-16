using CRUD_Form.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace CRUD_Form.Dal
{
    public class EmployeeDal
    {
        public List<Employee> GetAllEmployees()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["VishwasDbConStr"].ConnectionString))
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
                            Employee_id = Convert.ToInt32(DR["Employee_id"]),
                            Employee_Fullname = Convert.ToString(DR["Employee_Fullname"]),
                            Employee_joining_date = Convert.ToDateTime(DR["Employee_joining_date"]),
                            Employee_phone_number = Convert.ToInt32(DR["Employee_phone_number"]),
                            Employee_position = Convert.ToString(DR["Employee_position"]),
                            Employee_salary = Convert.ToInt32(DR["salary"])
                        });
                    }
                    DR.Close();
                    CN.Close();
                    return employees;
                }
            }
        }
        public int InsertEmployees(Employee employee)
        {
            using(MySqlConnection CN= new MySqlConnection(ConfigurationManager.ConnectionStrings["VishwasDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertEmployees";
                    CMD.Parameters.AddWithValue("P_Employee_id", employee.Employee_id);
                    CMD.Parameters.AddWithValue("P_Employee_fullname", employee.Employee_Fullname);
                    CMD.Parameters.AddWithValue("P_Employee_joining_date", employee.Employee_joining_date);
                    CMD.Parameters.AddWithValue("P_Employee_phone_number", employee.Employee_phone_number);
                    CMD.Parameters.AddWithValue("P_Employee_position", employee.Employee_position);
                    CMD.Parameters.AddWithValue("P_Salary", employee.Employee_salary);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int UpdateEmployee(Employee employee)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["VishwasDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType= CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateEmployee";
                    CMD.Parameters.AddWithValue("P_Employee_id", employee.Employee_id);
                    CMD.Parameters.AddWithValue("P_Employee_fullname", employee.Employee_Fullname);
                    CMD.Parameters.AddWithValue("P_Employee_joining_date", employee.Employee_joining_date);
                    CMD.Parameters.AddWithValue("P_Employee_phone_number", employee.Employee_phone_number);
                    CMD.Parameters.AddWithValue("P_Employee_position", employee.Employee_position);
                    CMD.Parameters.AddWithValue("P_Salary", employee.Employee_salary);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int deleteEmployee(Employee employee)
        {
            using(MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["VishwasDbConStr"].ConnectionString))
            {
                using(MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteEmployee";
                    CMD.Parameters.AddWithValue("P_EmployeeID", employee.Employee_id);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}
