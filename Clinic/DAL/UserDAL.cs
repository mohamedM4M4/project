using Clinic.DBContext;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL
{
    class UserDAL
    {

        ClinicDBContext ClinicDBContext;
        public UserDAL()
        {
            ClinicDBContext = new ClinicDBContext();
        }
        public List<User> GetAll() => ClinicDBContext.Users.ToList();

        public void Add(User user) => ClinicDBContext.Users.Add(user);
        public void Delete(int id)
        {
            ClinicDBContext.Users.SingleOrDefault(c => c.Id == id).Permissions.Clear();
            ClinicDBContext.Users.Remove(ClinicDBContext.Users.SingleOrDefault(c => c.Id == id));
        }
        public void AddPermission(int permissionId, int userId) => ClinicDBContext.Users.SingleOrDefault(c => c.Id == userId).Permissions.Add(ClinicDBContext.Permissions.SingleOrDefault(c => c.Id == permissionId));

        public void DeletePermission(int userId, int permissionID) =>
                ClinicDBContext.Users.SingleOrDefault(c => c.Id == userId).Permissions.Remove(ClinicDBContext.Permissions.SingleOrDefault(c => c.Id == permissionID));

        public int GetId(string userName) =>
            ClinicDBContext.Users.SingleOrDefault(c => c.Name.ToLower() == userName.ToLower()).Id;


        public User GetUser(string userName) =>
            ClinicDBContext.Users.Include("Permissions").SingleOrDefault(c => c.Name.ToLower() == userName.ToLower());

        public List<Permissions> GetUserPermission(int userID) =>
          ClinicDBContext.Users.SingleOrDefault(c => c.Id == userID).Permissions.ToList();
        public bool Exist(string name) =>
           ClinicDBContext.Users.Any(c => c.Name.Trim().ToLower() == name.Trim());

        public string GetPassword(string name) => ClinicDBContext.Users.SingleOrDefault(c => c.Name == name).Password;

        public bool CheckUserNameAndPassword(string userName, string password)
        {
            if (Exist(userName.ToLower()))
            {
                string encryptedPassword = new Encryption().Encrypte(password);
                if (GetPassword(userName) == encryptedPassword)
                    return true;
                return false;
            }
            else
                return false;

        }
        public bool CurrentPasswordTrue(string password, int userId)
        {
            password = new Encryption().Encrypte(password);
            var user = ClinicDBContext.Users.SingleOrDefault(c => c.Id == userId);
            return user.Password == password;
        }
        public void ChangePassword(string password, int userID)
        {
            password = new Encryption().Encrypte(password);
            var user = ClinicDBContext.Users.SingleOrDefault(c => c.Id == userID);
            user.Password = password;

        }
    }
}
