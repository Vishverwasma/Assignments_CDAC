using CRUD_Form.Dal;
using CRUD_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Form
{
    public partial class frmEmployeeCrudForm : Form
    {
        public frmEmployeeCrudForm()
        {
            InitializeComponent();
        }
        EmployeeDal employeeDal = new EmployeeDal();
        int index = 0;
        List<Employee> employeeList;

        private void frmEmployeeCrudForm_Load(object sender, EventArgs e)
        {
            employeeList = employeeDal.GetAllEmployees();
            Navigate(index);
        }
        private void Navigate(int currentIndex)
        {
            if (employeeList.Count > 0)
            {
                txtEmployeeID.Text = employeeList[currentIndex].Employee_id.ToString();
                txtFullName.Text = employeeList[currentIndex].Employee_Fullname.ToString();
                txtJoiningDate.Text = employeeList[currentIndex].Employee_joining_date.ToString();
                txtPhoneNumber.Text = employeeList[currentIndex].Employee_phone_number.ToString();
                txtPosition.Text = employeeList[currentIndex].Employee_position.ToString();
                txtSalary.Text = employeeList[currentIndex].Employee_salary.ToString();
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index);
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Navigate(index);
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (index < employeeList.Count - 1)
            {
                index++;
                Navigate(index);
            }
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            index = employeeList.Count - 1;
            Navigate(index);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = string.Empty;
            txtFullName.Text =  string.Empty; 
            txtJoiningDate.Text =  string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtPosition.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtEmployeeID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Employee_id = int.Parse(txtEmployeeID.Text),
                Employee_Fullname = txtFullName.Text,
                Employee_joining_date = DateTime.Parse(txtJoiningDate.Text),
                Employee_phone_number = int.Parse(txtPhoneNumber.Text),
                Employee_position = txtPosition.Text,
                Employee_salary = int.Parse(txtSalary.Text)
            };
            int result=employeeDal.InsertEmployees(employee);
            if (result > 0)
            {
                employeeList=employeeDal.GetAllEmployees();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Employee_id = int.Parse(txtEmployeeID.Text),
                Employee_Fullname = txtFullName.Text,
                Employee_joining_date = DateTime.Parse(txtJoiningDate.Text),
                Employee_phone_number = int.Parse(txtPhoneNumber.Text),
                Employee_position = txtPosition.Text,
                Employee_salary = int.Parse(txtSalary.Text)
            };
            int result = employeeDal.UpdateEmployee(employee);
            if (result > 0)
            {
                employeeList = employeeDal.GetAllEmployees();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Employee_id = int.Parse(txtEmployeeID.Text),
                Employee_Fullname = txtFullName.Text,
                Employee_joining_date = DateTime.Parse(txtJoiningDate.Text),
                Employee_phone_number = int.Parse(txtPhoneNumber.Text),
                Employee_position = txtPosition.Text,
                Employee_salary = int.Parse(txtSalary.Text)
            };
            int result = employeeDal.deleteEmployee(employee);
            if(result > 0)
            {
                employeeList = employeeDal.GetAllEmployees();
            }
        }
    }
}
