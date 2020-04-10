using Clinic.DBContext;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
  public  class AppointmentRepository
    {
        ClinicDBContext context = new ClinicDBContext();
        public Appointment Find(int id) => context.Appointments.SingleOrDefault(e => e.AppointmentId == id);
        public Appointment FindAppointmentWithPatientId(int id) => context.Appointments.SingleOrDefault(a =>a.Patient.PatientId == id);

        public void Remove(int id) => context.Appointments.Remove(Find(id));
        public void RemoveFromArchive(int id) => context.Appointments.Remove(FindAppointmentWithPatientId(id));

        public void Add(Appointment appointment) => context.Appointments.Add(appointment);
        public void Edit(Appointment appointment)
        {
            Appointment app1 = Find(appointment.AppointmentId);
            app1.Date = appointment.Date;
        }
        public void save() => context.SaveChanges();
        public List<Appointment> GetAppointments() => context.Appointments.Include("Assistant").Include("Patient").ToList();

    }
}
