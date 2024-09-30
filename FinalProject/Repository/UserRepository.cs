using FinalProject.Factory;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Repository
{
    public class UserRepository
    {
        static DatabaseEntities1 db = new DatabaseEntities1();
        public static MsUser CreateUser(String name, DateTime dob, String gender, String address, String password, String phone, String role)
        {
            MsUser user =  UserFactory.CreateUser(name, dob, gender, address, password, phone, role);

            db.MsUsers.Add(user);
            db.SaveChanges();

            return user;
        }

        public static MsUser LoginUser(String name, String password)
        {
            MsUser loginUser = db.MsUsers.Where(u => u.UserName == name && u.UserPassword == password).FirstOrDefault();

            return loginUser;
        }

        public static void UpdateUser(int id, String name, DateTime dob, String gender, String address, String password, String phone)
        {
            MsUser user = db.MsUsers.Find(id);

            user.UserName = name;
            user.UserDOB = dob;
            user.UserGender = gender;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UserPhone = phone;

            db.SaveChanges();
        }

        public static MsUser GetById(int id)
        {
            MsUser user = (from x in db.MsUsers where x.UserID == id select x).ToList().FirstOrDefault();
            return user;
        }

        public static bool IsUserNameExists(string name)
        {
            using (DatabaseEntities1 db = new DatabaseEntities1())
            {
                return db.MsUsers.Any(u => u.UserName == name);
            }
        }
    }
}