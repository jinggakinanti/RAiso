using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Factory
{
    public class UserFactory
    {
        public static MsUser CreateUser(String name, DateTime dob, String gender, String address, String password, String phone, String role)
        {
            MsUser user = new MsUser();
            user.UserName = name;
            user.UserDOB = dob;
            user.UserGender = gender;
            user.UserAddress = address;
            user.UserPhone = phone;
            user.UserPassword = password;
            user.UserRole = role;
            return user;
        }

        
    }
}