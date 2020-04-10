using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DBContext;
using Clinic.Model;
namespace Clinic.DAL
{
  public  class MedicineRepository
    {
        ClinicDBContext context = new ClinicDBContext();
        public Medicine Find(int id) => context.Medicines.SingleOrDefault(e => e.MedicineId == id);
        public void Remove(int id) => Find(id).IsDeleted = true;
        public void Add(Medicine medicine) => context.Medicines.Add(medicine);
        public List<Medicine> GetAll() => context.Medicines.Where(c => !c.IsDeleted).ToList();

        public void Edit(Medicine medicine)
        {
            Medicine med1 = Find(medicine.MedicineId);
            med1.Name = medicine.Name;
            med1.TimesPerDay = medicine.TimesPerDay;
            med1.StartDate = medicine.StartDate;
            med1.FinishDate = medicine.FinishDate;
            med1.Quantity = medicine.Quantity;
            med1.ConcentrationOfTheDrug = medicine.ConcentrationOfTheDrug;


        }
        public void save() => context.SaveChanges();
        public List<Medicine> GetMedicines() => context.Medicines.Include("Doctors").ToList();
       


    }
}
