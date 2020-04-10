using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Clinic.DAL
{
    class Encryption
    {
        public string Encrypte(string password)
        {
            using (MD5CryptoServiceProvider md = new MD5CryptoServiceProvider())
            {
                var bytes = md.ComputeHash(new UTF8Encoding().GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
