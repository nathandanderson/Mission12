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

        //Foreign key Relationship
        public int TimeValueId { get; set; }
        public TimeValue TimeValue { get; set; }

    }
}
