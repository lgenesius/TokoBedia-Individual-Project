using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_Project.Model;

namespace TokoBedia_Project.View
{
    public partial class Profile : System.Web.UI.Page
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
                        where g.Id == us.Id
                        select new
                        {
                            UserEmail = g.Email,
                            UserName = g.Name,
                            UserGender = g.Gender
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home2.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void btnChangePass_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}