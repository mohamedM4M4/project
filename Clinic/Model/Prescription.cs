using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
  public  class Prescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PrescriptionId { get; set; }
        public string DescriptionOfTheCase { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Clinic Clinic { get; set; }
        public ICollection<Medicine> Medicines { get; set; }



    }
}
