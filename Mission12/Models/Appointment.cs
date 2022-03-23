using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1,15)]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        //Foreign Key
        public int TimeID { get; set; }
        public Time Time { get; set; }

    }
}
