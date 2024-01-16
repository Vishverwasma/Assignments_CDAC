using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Synechron.EventsProtal.Models
{
    public class User
    {
        public int User_ID { get; set; }
        [Required(ErrorMessage = "Email ID is a required Field!")]
        [EmailAddress(ErrorMessage = "Please Provide Correct Email ID !")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is a Required Field !")]
        [MinLength(4,ErrorMessage = "Password must be Minimum of 4 Characters !")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Role-Name is a Required Field !")]
        [MinLength(4, ErrorMessage = "Role-Name is a must be among Employee or HR !")]
        public string Role_Name { get; set; }
    }
}