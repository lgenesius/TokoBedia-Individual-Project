using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_Project.Model;
using TokoBedia_Project.Repository;

namespace TokoBedia_Project.View
{
    public partial class ViewUser : System.Web.UI.Page
    {
        private Model.User us;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                if (Request.Cookies.Get("user") != null)
                {
                    HttpCookie cookie = Request.Cookies.Get("user");
                    int id = int.Parse(cookie.Value);
                    TokoBediaDatabaseEntities entity = new TokoBediaDatabaseEntities();
                    var x = (from user in entity.Users
                             where user.Id == id
                             select user).FirstOrDefault();
                    Session["user"] = x;
                }
                else
                {
                    Response.Redirect("Home1.aspx");
                }
            }
            us = (Model.User)Session["user"];
            loadgrid();
        }
        protected void loadgrid()
        {
            TokoBediaDatabaseEntities db = new TokoBediaDatabaseEntities();
            var query = from g in db.Users
                        select new
                        {
                            UserEmail = g.Email,
                            UserRole = g.Role_Id,
                            UserStatus = g.Status
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = TBEmail.Text.ToString();
            int role_id = Int32.Parse(TBRole.Text.ToString());
            string status = TBStatus.Text.ToString();

            if(status == "active" || status == "blocked")
            {
                if(DataRepository.getEmailByUser(email) != null)
                {
                    if(email != us.Email)
                    {
                        DataRepository.updateUser(email, role_id, status);
                        loadgrid();
                        LblError.Text = "Success Update!";
                    }
                    else
                    {
                        LblError.Text = "Tidak bisa mengubah role dan status sendiri";
                    }
                }
                else
                {
                    LblError.Text = "Email tersebut tidak ada di Database";
                }
            }
            else
            {
                LblError.Text = "status harus active atau blocked";
            }
        }
    }
}