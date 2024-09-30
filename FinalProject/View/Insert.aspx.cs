using FinalProject.Controller;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.View
{
    public partial class Insert1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            String name = TBox_Name.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(TBox_Price.Text))
            {
                Lbl_Status.Text = "All fields must be filled";
                return;
            }

            if (int.TryParse(TBox_Price.Text, out int price))
            {
                if (price < 2000)
                {
                    Lbl_Status.Text = "Price must be at least 2000";
                    return;
                }

                Lbl_Status.Text = StationeryController.CreateStationery(name, price);
            }
            else
            {
                Lbl_Status.Text = "Price must be a numeric value";
            }
        }
    }
}