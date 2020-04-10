using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using Clinic.DBContext;
using System.Data.Entity;

namespace Clinic.DAL
{
  public  class DoctorRepository
    {
        ClinicDBContext context = new ClinicDBContext();
        public Doctor Find(int id) => context.Doctors.SingleOrDefault(e => e.DoctorId == id);
        public void Remove(int id) => context.Doctors.Remove(Find(id));
        public void Add(Doctor doctor) => context.Doctors.Add(doctor);
        public void Edit(Doctor doctor)
        {
            Doctor doc1 = Find(doctor.DoctorId);
            doc1.FullName = doctor.FullName;
            doc1.Gender = doctor.Gender;
            doc1.Position = doctor.Position;
            doc1.Phone = doctor.Phone;
            doc1.DOB = doctor.DOB;
            doc1.Qualification = doctor.Qualification;
        }
        public void save() => context.SaveChanges();
        public List<Doctor> GetDoctorsWithPatients() => context.Doctors.Include("Patients").ToList();
        public List<Doctor> GetDoctorsWithClinics() => context.Doctors.Include("Clinics").ToList();
        public List<Doctor> GetDoctorsWithMedicines() => context.Doctors.Include("Medicines").ToList();


    }
}
