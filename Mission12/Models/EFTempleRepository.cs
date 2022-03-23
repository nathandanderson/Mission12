using System;
using System.Linq;

namespace Mission12.Models
{
    //implements and instance of ITempleRepository

    public class EFTempleRepository : ITempleRepository
    {
        private TempleContext context { get; set; }

        public EFTempleRepository(TempleContext temp)
        {
            context = temp;
        }

        public IQueryable<Appointment> Appointments => context.Appointments;

        public void SaveAppointment(Appointment a)
        {
            context.SaveChanges();
        }

        public void CreateAppointment(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void DeleteAppointment(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }
    }
}
