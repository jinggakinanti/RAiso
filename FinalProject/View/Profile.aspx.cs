using FinalProject.Controller;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MsUser currentUser = (MsUser)Session["user"];

                if(currentUser != null)
                {
                    TBox_Name.Text = currentUser.UserName;
                    Calendar_DOB.SelectedDate = currentUser.UserDOB;
                    TBox_DOB.Text = currentUser.UserDOB.ToString("dd/MM/yyyy");
                    RBL_Gender.SelectedValue = currentUser.UserGender;
                    TBox_Address.Text = currentUser.UserAddress;
                    TBox_Password.Text = currentUser.UserPassword;
                    TBox_Phone.Text = currentUser.UserPhone;
                    
                }
                else
                {
                    Lbl_Status.Text = "User is not logged in";
                }

                if (Session["UpdateSuccess"] != null)
                {
                    Lbl_Status.Text = Session["UpdateSuccess"].ToString();
                    
                    Session["UpdateSuccess"] = null;
                }
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            MsUser currentUser = (MsUser)Session["user"];
            if (RBL_Gender.SelectedIndex == -1)
            {
                Lbl_Status.Text = "All fields must be filled";
                return;
            }

            int id = currentUser.UserID;
            String name = TBox_Name.Text;
            DateTime dob = Calendar_DOB.SelectedDate;
            String gender = RBL_Gender.SelectedItem.Text;
            String address = TBox_Address.Text;
            String password = TBox_Password.Text;
            String phone = TBox_Phone.Text;

            if (name == "" || address == "" || password == "" || phone == "")
            {
                Lbl_Status.Text = "All fields must be filled";
                return;
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                Lbl_Status.Text = "Name must be between 5 and 50 characters";
                return;
            }
            else if (Calendar_DOB.SelectedDate != DateTime.MinValue)
            {
                DateTime minDate = DateTime.Now.AddYears(-1);

                if (Calendar_DOB.SelectedDate > minDate)
                {
                    Lbl_Status.Text = "You must be at least 1 year old";
                    return;
                }
            }
            else if (Calendar_DOB.SelectedDate == DateTime.MinValue)
            {
                Lbl_Status.Text = "All fields must be filled";
                return;
            }

            UserController.UpdateUser(id, name, dob, gender, address, password, phone);
            Session["UpdateSuccess"] = "Profile updated successfully";
            Response.Redirect("~/View/Profile.aspx");
            
        }

        protected void Calendar_DOB_SelectionChanged(object sender, EventArgs e)
        {
            TBox_DOB.Text = Calendar_DOB.SelectedDate.ToString("dd/MM/yyyy");
        }
    }
}