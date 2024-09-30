using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Handler
{
    public class UserHandler
    {
        public static MsUser CreateUser(String name, DateTime dob, String gender, String address, String password, String phone, String role)
        {
            MsUser user = UserRepository.CreateUser(name, dob, gender, address, password, phone, role);

            return user;
        }

        public static void UpdateUser(int id, String name, DateTime dob, String gender, String address, String password, String phone)
        {
            UserRepository.UpdateUser(id, name, dob, gender, address, password, phone);
        }

        public static MsUser LoginUser(String name, String password)
        {
            MsUser user = UserRepository.LoginUser(name, password);
            return user;
        }
    }
}