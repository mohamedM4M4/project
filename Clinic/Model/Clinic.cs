using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
   
    public class Clinic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClinicId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Doctor> Doctors { get; set; }

    }
}
