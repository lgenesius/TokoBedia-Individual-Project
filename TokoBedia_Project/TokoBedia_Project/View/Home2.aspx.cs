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
    public partial class Home : System.Web.UI.Page
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
            LblWelcome.Text = Session["username"].ToString();
            if (us.Role_Id == 1)
            {
                btnProductType.Visible = true;
                btnViewUser.Visible = true;
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            HttpCookie cookie = Response.Cookies.Get("user");
            cookie.Expires = DateTime.Now.AddHours(-1);
            Response.Redirect("LoginForm.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }

        protected void btnProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductType.aspx");
        }

        protected void btnViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

    }
   
}