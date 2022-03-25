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

        public virtual DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
                new Time { TimeID = 1, Date = "3/23/2022", Booked = false, TimeValue = "8:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 2, Date = "3/23/2022", Booked = false, TimeValue = "9:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 3, Date = "3/23/2022", Booked = false, TimeValue = "10:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 4, Date = "3/23/2022", Booked = false, TimeValue = "11:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 5, Date = "3/23/2022", Booked = false, TimeValue = "12:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 6, Date = "3/23/2022", Booked = false, TimeValue = "1:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 7, Date = "3/23/2022", Booked = false, TimeValue = "2:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 8, Date = "3/23/2022", Booked = false, TimeValue = "3:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 9, Date = "3/23/2022", Booked = false, TimeValue = "4:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 10, Date = "3/23/2022", Booked = false, TimeValue = "5:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 11, Date = "3/23/2022", Booked = false, TimeValue = "6:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 12, Date = "3/23/2022", Booked = false, TimeValue = "7:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 13, Date = "3/23/2022", Booked = false, TimeValue = "8:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },


                new Time { TimeID = 14, Date = "3/24/2022", Booked = false, TimeValue = "8:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 15, Date = "3/24/2022", Booked = false, TimeValue = "9:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 16, Date = "3/24/2022", Booked = false, TimeValue = "10:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 17, Date = "3/24/2022", Booked = false, TimeValue = "11:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 18, Date = "3/24/2022", Booked = false, TimeValue = "12:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 19, Date = "3/24/2022", Booked = false, TimeValue = "1:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 20, Date = "3/24/2022", Booked = false, TimeValue = "2:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 21, Date = "3/24/2022", Booked = false, TimeValue = "3:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 22, Date = "3/24/2022", Booked = false, TimeValue = "4:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 23, Date = "3/24/2022", Booked = false, TimeValue = "5:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 24, Date = "3/24/2022", Booked = false, TimeValue = "6:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 25, Date = "3/24/2022", Booked = false, TimeValue = "7:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 26, Date = "3/24/2022", Booked = false, TimeValue = "8:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },


                new Time { TimeID = 27, Date = "3/25/2022", Booked = false, TimeValue = "8:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 28, Date = "3/25/2022", Booked = false, TimeValue = "9:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 29, Date = "3/25/2022", Booked = false, TimeValue = "10:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 30, Date = "3/25/2022", Booked = false, TimeValue = "11:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 31, Date = "3/25/2022", Booked = false, TimeValue = "12:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 32, Date = "3/25/2022", Booked = false, TimeValue = "1:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 33, Date = "3/25/2022", Booked = false, TimeValue = "2:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 34, Date = "3/25/2022", Booked = false, TimeValue = "3:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 35, Date = "3/25/2022", Booked = false, TimeValue = "4:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 36, Date = "3/25/2022", Booked = false, TimeValue = "5:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 37, Date = "3/25/2022", Booked = false, TimeValue = "6:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 38, Date = "3/25/2022", Booked = false, TimeValue = "7:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 39, Date = "3/25/2022", Booked = false, TimeValue = "8:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },


                new Time { TimeID = 40, Date = "3/26/2022", Booked = false, TimeValue = "8:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 41, Date = "3/26/2022", Booked = false, TimeValue = "9:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 42, Date = "3/26/2022", Booked = false, TimeValue = "10:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 43, Date = "3/26/2022", Booked = false, TimeValue = "11:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 44, Date = "3/26/2022", Booked = false, TimeValue = "12:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 45, Date = "3/26/2022", Booked = false, TimeValue = "1:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 46, Date = "3/26/2022", Booked = false, TimeValue = "2:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 47, Date = "3/26/2022", Booked = false, TimeValue = "3:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 48, Date = "3/26/2022", Booked = false, TimeValue = "4:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 49, Date = "3/26/2022", Booked = false, TimeValue = "5:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 50, Date = "3/26/2022", Booked = false, TimeValue = "6:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 51, Date = "3/26/2022", Booked = false, TimeValue = "7:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 52, Date = "3/26/2022", Booked = false, TimeValue = "8:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },


                new Time { TimeID = 53, Date = "3/27/2022", Booked = false, TimeValue = "8:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 54, Date = "3/27/2022", Booked = false, TimeValue = "9:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 55, Date = "3/27/2022", Booked = false, TimeValue = "10:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 56, Date = "3/27/2022", Booked = false, TimeValue = "11:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 57, Date = "3/27/2022", Booked = false, TimeValue = "12:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 58, Date = "3/27/2022", Booked = false, TimeValue = "1:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 59, Date = "3/27/2022", Booked = false, TimeValue = "2:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 60, Date = "3/27/2022", Booked = false, TimeValue = "3:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 61, Date = "3/27/2022", Booked = false, TimeValue = "4:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 62, Date = "3/27/2022", Booked = false, TimeValue = "5:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 63, Date = "3/27/2022", Booked = false, TimeValue = "6:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 64, Date = "3/27/2022", Booked = false, TimeValue = "7:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 65, Date = "3/27/2022", Booked = false, TimeValue = "8:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },


                new Time { TimeID = 66, Date = "3/28/2022", Booked = false, TimeValue = "8:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 67, Date = "3/28/2022", Booked = false, TimeValue = "9:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 68, Date = "3/28/2022", Booked = false, TimeValue = "10:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 69, Date = "3/28/2022", Booked = false, TimeValue = "11:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 70, Date = "3/28/2022", Booked = false, TimeValue = "12:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 71, Date = "3/28/2022", Booked = false, TimeValue = "1:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 72, Date = "3/28/2022", Booked = false, TimeValue = "2:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 73, Date = "3/28/2022", Booked = false, TimeValue = "3:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 74, Date = "3/28/2022", Booked = false, TimeValue = "4:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 75, Date = "3/28/2022", Booked = false, TimeValue = "5:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 76, Date = "3/28/2022", Booked = false, TimeValue = "6:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 77, Date = "3/28/2022", Booked = false, TimeValue = "7:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 78, Date = "3/28/2022", Booked = false, TimeValue = "8:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },


                new Time { TimeID = 79, Date = "3/29/2022", Booked = false, TimeValue = "8:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 80, Date = "3/29/2022", Booked = false, TimeValue = "9:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 81, Date = "3/29/2022", Booked = false, TimeValue = "10:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 82, Date = "3/29/2022", Booked = false, TimeValue = "11:00 AM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 83, Date = "3/29/2022", Booked = false, TimeValue = "12:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 84, Date = "3/29/2022", Booked = false, TimeValue = "1:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 85, Date = "3/29/2022", Booked = false, TimeValue = "2:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 86, Date = "3/29/2022", Booked = false, TimeValue = "3:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 87, Date = "3/29/2022", Booked = false, TimeValue = "4:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 88, Date = "3/29/2022", Booked = false, TimeValue = "5:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 89, Date = "3/29/2022", Booked = false, TimeValue = "6:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 90, Date = "3/29/2022", Booked = false, TimeValue = "7:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null },
                new Time { TimeID = 91, Date = "3/29/2022", Booked = false, TimeValue = "8:00 PM", GroupName = null, GroupSize = 0, Email = null, Phone = null }


                );
        }
    }
}