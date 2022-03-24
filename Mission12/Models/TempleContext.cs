using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class TempleContext : DbContext
    {
        public TempleContext()
        {
        }
        public TempleContext(DbContextOptions<TempleContext> options) : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //mb.Entity<TimeValue>().HasData(
            //     new TimeValue { TimeValueId = 1, TimeValueName = "8:00 AM" },
            //     new TimeValue { TimeValueId = 2, TimeValueName = "9:00 AM" },
            //     new TimeValue { TimeValueId = 3, TimeValueName = "10:00 AM" },
            //     new TimeValue { TimeValueId = 4, TimeValueName = "11:00 AM" },
            //     new TimeValue { TimeValueId = 5, TimeValueName = "12:00 AM" },
            //     new TimeValue { TimeValueId = 6, TimeValueName = "1:00 PM" },
            //     new TimeValue { TimeValueId = 7, TimeValueName = "2:00 PM" },
            //     new TimeValue { TimeValueId = 8, TimeValueName = "3:00 PM" },
            //     new TimeValue { TimeValueId = 9, TimeValueName = "4:00 PM" },
            //     new TimeValue { TimeValueId = 10, TimeValueName = "5:00 PM" },
            //     new TimeValue { TimeValueId = 11, TimeValueName = "6:00 PM" },
            //     new TimeValue { TimeValueId = 12, TimeValueName = "7:00 PM" },
            //     new TimeValue { TimeValueId = 13, TimeValueName = "8:00 PM" }
            //    );

            mb.Entity<Time>().HasData(
                new Time { TimeID = 1, Date="3/23/2022", Booked=true, TimeValue = "8:00 AM"},
                new Time { TimeID = 2, Date = "3/23/2022", Booked = true, TimeValue = "9:00 AM" },
                new Time { TimeID = 3, Date = "3/23/2022", Booked = true, TimeValue = "10:00 AM" },
                new Time { TimeID = 4, Date = "3/23/2022", Booked = true, TimeValue = "11:00 AM" },
                new Time { TimeID = 5, Date = "3/23/2022", Booked = true, TimeValue = "12:00 PM" },
                new Time { TimeID = 6, Date = "3/23/2022", Booked = true, TimeValue = "1:00 PM" },
                new Time { TimeID = 7, Date = "3/23/2022", Booked = true, TimeValue = "2:00 PM" },
                new Time { TimeID = 8, Date = "3/23/2022", Booked = true, TimeValue = "3:00 PM" },
                new Time { TimeID = 9, Date = "3/23/2022", Booked = true, TimeValue = "4:00 PM" },
                new Time { TimeID = 10, Date = "3/23/2022", Booked = true, TimeValue = "5:00 PM" },
                new Time { TimeID = 11, Date = "3/23/2022", Booked = true, TimeValue = "6:00 PM" },
                new Time { TimeID = 12, Date = "3/23/2022", Booked = true, TimeValue = "7:00 PM" },
                new Time { TimeID = 13, Date = "3/23/2022", Booked = true, TimeValue = "8:00 PM" }
                );

            mb.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentID = 1,
                    GroupName = "Nathan's Party Group",
                    GroupSize = 1,
                    Email = "Test@test.com",
                    Phone = "911",
                    TimeID = 1
                }
             );
        }
    }
}