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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseEntities1 db = new DatabaseEntities1();
            MsUser currentUser = (MsUser)Session["user"];

            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Btn_Insert.Visible = false;
                    GView_Stat.Columns[3].Visible = false;
                    GView_Stat.Columns[4].Visible = false;

                    if (Request.Cookies["user_cookie"] != null)
                    {
                        string userName = Request.Cookies["user_cookie"].Value;

                        MsUser cookieUser = db.MsUsers.FirstOrDefault(u => u.UserName == userName);

                        if (cookieUser != null)
                        {
                            Session["user"] = cookieUser;
                            currentUser = cookieUser; // Update currentUser to the cookie user
                            SetUserCookie(userName); // Refresh the cookie expiration time
                        }
                    }
                }

                if (currentUser != null)
                {
                    if (currentUser.UserRole == "Customer")
                    {
                        Btn_Insert.Visible = false;
                        GView_Stat.Columns[4].Visible = false;
                    }
                    else if (currentUser.UserRole == "Admin")
                    {
                        GView_Stat.Columns[3].Visible = false;
                    }
                }

                GView_Stat.DataSource = StationeryController.GetStationeries();
                GView_Stat.DataBind();
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Insert.aspx");
        }

        protected void GView_Stat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GView_Stat.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            
            StationeryRepository.DeleteProduct(id);
            Response.Redirect("~/View/Home.aspx");
        }

        protected void GView_Stat_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GView_Stat.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/View/Update.aspx?Id=" + id);

        }

        protected void GView_Stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GView_Stat.SelectedRow.Cells[0].Text);
            Response.Redirect("~/View/Detail.aspx?Id=" + id);
        }

        protected void SetUserCookie(string userName)
        {
            HttpCookie userCookie = new HttpCookie("user_cookie");
            userCookie.Value = userName;
            userCookie.Expires = DateTime.Now.AddHours(1); // Set the cookie to expire in 1 hour
            Response.Cookies.Add(userCookie);
        }


    }
}