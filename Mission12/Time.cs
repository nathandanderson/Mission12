using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Time
    {
        [Key]
        public int TimeID {get; set;}

        public string Date { get; set; }
        public bool Booked { get; set; }
        public string TimeValue { get; set; }

        //Appointment group info
        public string GroupName { get; set; }
        [Range(1, 15)]
        public int GroupSize { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


    }
}
