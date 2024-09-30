using FinalProject.Controller;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            String name = TBox_Name.Text;
            String password = TBox_Password.Text;
            Boolean remember = CBox_Remember.Checked;

            if (name == "" || password == "")
            {
                Lbl_Status.Text = "All fields must be filled";
            }
            
            MsUser loginUser = UserController.LoginUser(name, password);

            if (loginUser != null)
            {
                Session["user"] = loginUser;

                if(remember == true) {
                    HttpCookie cookie = new HttpCookie("cookieId");
                    cookie.Value = loginUser.UserName;

                    cookie.Expires = DateTime.Now.AddHours(2);

                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                Lbl_Status.Text = "Incorrect name or password";
            }
        }
    }
}