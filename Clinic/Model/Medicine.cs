using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
   public class Medicine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MedicineId { get; set; }
        public string Name { get; set; }
        public int ConcentrationOfTheDrug { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public int Quantity { get; set; }
        public int TimesPerDay { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Doctor> Doctors;
    }
}
