using FinalProject.Controller;
using FinalProject.Handler;
using FinalProject.Model;
using FinalProject.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.View
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseEntities1 db = new DatabaseEntities1();
            MsUser currentUser = (MsUser)Session["user"];

            if (!IsPostBack)
            {
                
                GView_Cart.DataSource = CartController.GetCarts();
                GView_Cart.DataBind();
            }
        }

        protected void Btn_Checkout_Click(object sender, EventArgs e)
        {
            try
            {
                MsUser currentUser = (MsUser)Session["user"];
                if (currentUser == null)
                {
                    Response.Redirect("~/Login.aspx");
                    return;
                }

                var cartList = CartController.GetCarts();
                TransactionHeader history = TransactionController.CreateTransaction(currentUser.UserID, cartList, DateTime.Now);

                foreach (var cart in cartList)
                {
                    CartController.DeleteCart(cart.UserID, cart.StationeryID);
                }

                ScriptManager.RegisterStartupScript(this, GetType(), "redirect", "alert('Checkout successful!'); window.location='" + Request.ApplicationPath + "View/Home.aspx';", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Error during checkout: " + ex.Message + "');", true);
            }
        }

        protected void GView_Cart_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GView_Cart.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/View/CartUpdate.aspx?Id=" + id);
        }

        protected void GView_Cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GView_Cart.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            CartController.DeleteProduct(id);
            Response.Redirect("~/View/Cart.aspx");
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

        protected void GView_Cart_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                Label Lbl_Name = (Label)e.Row.FindControl("Lbl_Name");
                Label Lbl_Price = (Label)e.Row.FindControl("Lbl_Price");

                if (Lbl_Name != null)
                {
                    int stationeryId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "StationeryId"));
                    Lbl_Name.Text = GetStatName(stationeryId);
                }
                if (Lbl_Price != null)
                {
                    int stationeryId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "StationeryId"));
                    Lbl_Price.Text = GetStatPrice(stationeryId).ToString();
                }
            }
        }
    }
}