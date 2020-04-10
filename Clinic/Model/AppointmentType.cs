using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
   public class AppointmentType
    {

        public int Id { get; set; }
        public string AppointmentTypeForPatient { get; set; }
    }
}
