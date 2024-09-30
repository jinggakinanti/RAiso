using FinalProject.Controller;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FinalProject.View
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String Id = Request["Id"];
                MsStationery stat = StationeryRepository.GetById(Convert.ToInt32(Id));
                if(stat != null)
                {
                    TBox_Name.Text = stat.StationeryName;
                    TBox_Price.Text = stat.StationeryPrice.ToString();
                }
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            String Id = Request["Id"];
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

                StationeryController.UpdateStationery(Convert.ToInt32(Id), name, price);
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {   
                Lbl_Status.Text = "Price must be a numeric value";
            }

        }
    }
}