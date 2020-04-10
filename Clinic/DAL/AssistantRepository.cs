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
  public  class AssistantRepository
    {
        ClinicDBContext context = new ClinicDBContext();
        public Assistant Find(int id) => context.Assistants.SingleOrDefault(e => e.AssistantId == id);
        public void Remove(int id) => context.Assistants.Remove(Find(id));
        public void Add(Assistant assistant) => context.Assistants.Add(assistant);
        public void Edit(Assistant assistant)
        {
            Assistant asst1 =Find(assistant.AssistantId);
            asst1.Name = assistant.Name;
            asst1.Phone = assistant.Phone;
            asst1.Salary = assistant.Salary;

        }
        public void save() => context.SaveChanges();
        public List<Assistant> GetAssistants() => context.Assistants.Include("Appointments").Include("Patients").ToList();


    }
}
