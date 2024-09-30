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
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                int transactionId = 0;
                if (int.TryParse(Request.QueryString["TransactionID"], out transactionId))
                {
                    GView_Detail.DataSource = DetailController.GetDetails(transactionId);
                    GView_Detail.DataBind();
                }
                else
                {
                    Response.Write("Transaction ID is not valid.");
                }
            }
        }


        protected string GetStatName(int stationeryId)
        {
            CartRepository repo = new CartRepository();

            string name = repo.GetNameById(stationeryId);

            return name;
        }

        protected int GetStatPrice(int stationeryId)
        {
            CartRepository repo = new CartRepository();

            int price = repo.GetPriceById(stationeryId);

            return price;
        }

        protected void GView_Detail_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label Lbl_Name = (Label)e.Row.FindControl("Lbl_Name");
                Label Lbl_Price = (Label)e.Row.FindControl("Lbl_Price");

                if (Lbl_Name != null)
                {
                    int stationeryId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "StationeryID"));
                    Lbl_Name.Text = GetStatName(stationeryId);
                }
                if (Lbl_Price != null)
                {
                    int stationeryId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "StationeryID"));
                    Lbl_Price.Text = GetStatPrice(stationeryId).ToString();
                }
            }
        }
    }
}
