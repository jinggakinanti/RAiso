using FinalProject.Controller;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            if (RBL_Gender.SelectedIndex == -1)
            {
                Lbl_Status.Text = "All fields must be filled";
                return;
            }

            String name = TBox_Name.Text;
            DateTime dob = Calendar_DOB.SelectedDate;
            String gender = RBL_Gender.SelectedItem.Text;
            String address = TBox_Address.Text;
            String password = TBox_Password.Text;
            String phone = TBox_Phone.Text;
            String role = "Customer";

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
            else if (UserRepository.IsUserNameExists(name))
            {
                Lbl_Status.Text = "Name already in use";
                return;
            }
            else if (!IsAlphanumeric(password))
            {
                Lbl_Status.Text = "Password must be alphanumeric and contain at least one letter and one digit";
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

            Lbl_Status.Text = UserController.Createuser(name, dob, gender, address, password, phone, role);
        }

        private bool IsAlphanumeric(string str)
        {
            return Regex.IsMatch(str, "^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$");
        }
    }
}