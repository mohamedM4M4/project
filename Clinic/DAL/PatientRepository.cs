using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DBContext;
using Clinic.Model;


namespace Clinic.DAL
   
{
   public class PatientRepository
    {
        ClinicDBContext context = new ClinicDBContext();
        public Patient Find(int id) => context.Patients.SingleOrDefault(e => e.PatientId == id);

        public void Remove(int id)=>Find(id).IsDeleted = true ;
        public void RemoveFromArchive(int id) 
        {
            AppointmentRepository appointmentRepository = new AppointmentRepository();
            appointmentRepository.RemoveFromArchive(id);
            appointmentRepository.save();
            context.Patients.Remove(Find(id)); 
     
        }

        public List<Patient> GetPatienWithSpcificName(string Name) => context.Patients.Where(p => p.FullName.Contains(Name)).ToList();

        public List<Patient> GetPatienDeletedWithSpcificName(string Name) => context.Patients.Where(p => p.FullName.Contains(Name)).Where(p=>p.IsDeleted==true).ToList();

        public List<Patient> GetAll() => context.Patients.Where(c=>!c.IsDeleted).ToList();
        public List<Patient> GetAllDeletedPatient() => context.Patients.Where(c => c.IsDeleted==true).ToList();

        public List<string> GetFullName() => context.Patients.Where(p => !p.IsDeleted).Select(p => p.FullName).ToList();
        public List<string> GetFullNameForDeletedPatient() => context.Patients.Where(p => p.IsDeleted==true).Select(p => p.FullName).ToList();
        public List<Patient> GetPatients() => context.Patients.Include("Doctor").Include("Assistant").ToList();

        public void Add(Patient patient) => context.Patients.Add(patient);
        public void Edit(Patient patient)
        {
            Patient p1 = Find(patient.PatientId);
            p1.FullName = patient.FullName;
            p1.Phone = patient.Phone;
            p1.Gender.Id = patient.Gender.Id;
            p1.Address = patient.Address;
            p1.Age = patient.Age;
        }

        public void Recovery(int id) => Find(id).IsDeleted = false;
        

        public void save() => context.SaveChanges();
        //public List<Patient> GetAllPatientForThisDay()
        //{

        //    List<Patient> patients =
        //        context.Patients.Join(context.Appointments,
        //                    p => p.PatientId,
        //                    a => a.Patient.PatientId,
        //                    (patient) => new
        //                    {
        //                        patients = patient
        //                    })
        //         .Where(a => a.Date == DateTime.Now.ToShortDateString());


        //    return patients;
        //}

    }
}
