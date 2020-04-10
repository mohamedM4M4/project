using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
  public  class Assistant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AssistantId { get; set; }
        public string Name { get; set; }
       
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public float Salary { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
