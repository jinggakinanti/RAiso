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
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String Id = Request["Id"];
                MsStationery stat = StationeryRepository.GetById(Convert.ToInt32(Id));
                if (stat != null)
                {
                    TBox_Name.Text = stat.StationeryName;
                    TBox_Price.Text = stat.StationeryPrice.ToString();
                }
            }
        }

        protected void Btn_Add_Click(object sender, EventArgs e)
        {
            MsUser currentUser = (MsUser)Session["user"];
            int userId = currentUser.UserID;
            String Id = Request["Id"];

            if (int.TryParse(TBox_Quantity.Text, out int quantity))
            {
                if (quantity <= 0)
                {
                    Lbl_Status.Text = "Must be at least 1";
                    return;
                }

                CartController.CreateCart(userId, Convert.ToInt32(Id), quantity);
                Lbl_Status.Text = "Added to cart successfully";
            }
            else
            {
                Lbl_Status.Text = "Quantity must be a numeric value";
            }
        }
    }
}