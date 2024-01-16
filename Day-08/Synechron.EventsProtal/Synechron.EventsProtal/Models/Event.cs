using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Synechron.EventsProtal.Models
{
    public class Event
    {
        public int Event_ID { get; set; }
        [Required(ErrorMessage = "Event Code is Required Field ! ")]
        [MinLength(6,ErrorMessage = "Event Code Should Not Be Less Than 6 Characters !")]
        [MaxLength(6,ErrorMessage = "Event Code Should Not Be More Than 6 Characters !")]
        public string Event_Code { get; set; }
        [Required(ErrorMessage = "Event Name is A Required Field!")]
        public string Event_Name { get; set; }
        [Required(ErrorMessage = "Event Description is A Required Field!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Event Start Date is A Required Field!")]
        public DateTime Start_Date { get; set; }
        [Required(ErrorMessage = "Event End Date is A Required Field!")]
        public DateTime End_Date { get; set; }
        [Required(ErrorMessage = "Event Fees is A Required Field!")]
        public decimal Fees { get; set; }
        [Required(ErrorMessage = "Event's Total Seats Filled is A Required Field!")]
        public int Total_Seats_Filled { get; set; }
        [Required(ErrorMessage = "Event Logo is A Required Field!")]
        public string LOGO { get; set; }
    }
}