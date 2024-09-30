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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser currentUser = (MsUser)Session["user"];
            if (!IsPostBack)
            {
                GView_Transaction.Columns[2].Visible = false;
                GView_Transaction.DataSource = TransactionController.GetTransactions(currentUser.UserID);
                GView_Transaction.DataBind();
            }
        }

        protected void GView_Transaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GView_Transaction.SelectedRow.Cells[0].Text);
            Response.Redirect("~/View/TransactionDetail.aspx?TransactionID=" + id);
        }

        protected string GetUserName(int userId)
        {
            TransactionRepository repo = new TransactionRepository();

            string name = repo.GetNameById(userId);

            return name;
        }

        protected void GView_Transaction_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label Lbl_Name = (Label)e.Row.FindControl("Lbl_Name");

                if (Lbl_Name != null)
                {
                    int userId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "UserID"));
                    Lbl_Name.Text = GetUserName(userId);
                }
            }
        }
    }
}