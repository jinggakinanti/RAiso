using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Master
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser currentUser = (MsUser)Session["user"];

            if (Session["user"] == null)
            {
                Btn_Login.Visible = true;
                Btn_Register.Visible = true;
                Btn_Home.Visible = true;
                Btn_Cart.Visible = false;
                Btn_Transaction.Visible = false;
                Btn_Update.Visible = false;
                Btn_Logout.Visible = false;
            }
            else
            {
                Btn_Login.Visible = false;
                Btn_Register.Visible = false;
                Btn_Home.Visible = true;
                //Btn_Cart.Visible = true;
                Btn_Transaction.Visible = true;
                Btn_Update.Visible = true;
                Btn_Logout.Visible = true;
                if(currentUser.UserRole == "Customer")
                {
                    Btn_Cart.Visible = true;
                }
                else
                {
                    Btn_Cart.Visible = false;
                }
            }
        }

        protected void Btn_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }

        protected void Btn_Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cart.aspx");
        }

        protected void Btn_Transaction_Click(object sender, EventArgs e)
        {
            MsUser currentUser = (MsUser)Session["user"];

            if (currentUser.UserRole == "Customer")
                {
                Response.Redirect("~/View/TransactionHistory.aspx");
            }
                else
            {
                Response.Redirect("~/View/TransactionReport.aspx");
            }
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["cookieId"] != null)
            {
                HttpCookie myCookie = new HttpCookie("cookieId");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }
            Session.Remove("user");
            Session.Abandon();
            Response.Redirect("~/View/Home.aspx");
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }
    }
}