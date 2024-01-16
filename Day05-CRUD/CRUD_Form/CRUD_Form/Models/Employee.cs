using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Form.Models
{
    public class Employee
    {
        public int Employee_id{ get; set; }
        public string Employee_Fullname { get; set; }
        public DateTime Employee_joining_date { get; set; }
        public int Employee_phone_number { get; set; }
        public string Employee_position { get; set; }
        public int Employee_salary { get; set; }
    }
}
