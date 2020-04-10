using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DBContext;
using Clinic.Model;
namespace Clinic.DAL
{
 public   class ClinicRepository
    {
        ClinicDBContext context = new ClinicDBContext();
        public Model.Clinic Find(int id) => context.Clinics.SingleOrDefault(e => e.ClinicId == id);
        public void Remove(int id) => context.Clinics.Remove(Find(id));
        public void Add(Model.Clinic clinic) => context.Clinics.Add(clinic);
        public void Edit(Model.Clinic clinic)
        {
           Model.Clinic clinic1 = Find(clinic.ClinicId);
            clinic1.Name = clinic.Name;
            clinic1.Location = clinic.Location;
        }
        public void save() => context.SaveChanges();
        public List<Model.Clinic> GetClinics() => context.Clinics.Include("Doctors").ToList();


    }
}
