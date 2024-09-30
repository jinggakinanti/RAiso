using FinalProject.Handler;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Controller
{
    public class UserController
    {
        public static String Createuser(String name, DateTime dob, String gender, String address, String password, String phone, String role)
        {
            
            MsUser user = UserHandler.CreateUser(name, dob, gender, address, password, phone, role);

            return "Register Succesful";
        }

        public static void UpdateUser(int id, String name, DateTime dob, String gender, String address, String password, String phone)
        {
            UserHandler.UpdateUser(id, name, dob, gender, address, password, phone);
        }

        public static MsUser LoginUser(String name, String password)
        {
            MsUser user = UserHandler.LoginUser(name, password);
            return user;
        }
    }
}