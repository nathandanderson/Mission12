using System;
using System.Linq;

namespace Mission12.Models
{
    // interface is a template for a class
    public interface ITempleRepository
    {
        IQueryable<Appointment> Appointments { get; }

        public void SaveAppointment(Appointment a);
        public void CreateAppointment(Appointment a);
        public void DeleteAppointment(Appointment a);
    }
}
