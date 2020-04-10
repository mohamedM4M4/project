using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    public class Doctor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DoctorId { get; set; }
        public string FullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Position { get; set; }
        public string DOB { get; set; }
        public string Qualification { get; set; }
      
        public Gender Gender { get; set; }

        public ICollection<Patient> Patients { get; set; }
        public ICollection<Clinic> Clinics { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }

    }
}
