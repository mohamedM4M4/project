using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{

    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public bool IsExamined { get; set; }
        public string Address { get; set; }
        public int Order { get; set; }
        public double Age { get; set; }
        [ForeignKey("Gender")]
        public int GenderId { get; set; }
        public bool IsDeleted{ get; set; }
        public bool IsEntered { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}
