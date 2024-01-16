using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Synechron.EventsProtal.Models
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        [Required(ErrorMessage = "Employee Name is a required Field !")]
        public string Employee_Name { get; set; }
        [Required(ErrorMessage = "Employee Address is a required Field !")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is a required Field !")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country is a required Field !")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Phone Number is a required Field !")]
        public string Phone_Number { get; set; }
        [Required(ErrorMessage = "Email is a required Field !")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Skill Sets is a required Field !")]
        public string Skill_Sets { get; set; }
        [Required(ErrorMessage = "Avatar is a required Field !")]
        public string Avatar { get; set; }
        [Required(ErrorMessage = "Zip-Code is a required Field !")]
        public string ZipCode { get; set; }
    }

}