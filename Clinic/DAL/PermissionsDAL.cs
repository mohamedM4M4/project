using Clinic.DBContext;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    class PermissionsDAL
    {
        public List<Permissions> GetAll()
        {
            using(ClinicDBContext entites = new ClinicDBContext())
            {
                return entites.Permissions.ToList();
            }
        }
    }
}
