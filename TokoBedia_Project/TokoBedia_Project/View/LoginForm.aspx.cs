using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_Project.Model;

namespace TokoBedia_Project.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TBPassword.Attributes["type"] = "password";
            if (!IsPostBack)
            {
                if (Request.Cookies["email1"] != null && Request.Cookies["password1"] != null)
                {
                    TBEmail.Text = Request.Cookies["email1"].Value;
                    TBPassword.Text = Request.Cookies["password1"].Value;
                }
                {

                }
            }
            if (Session["user"] != null)
            {
                Response.Redirect("Home2.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = TBEmail.Text;
            string password = TBPassword.Text;

            TokoBediaDatabaseEntities entity = new Model.TokoBediaDatabaseEntities();
            var x = (from user in entity.Users
                     where user.Email == email
                     && user.Password == password
                     select user).FirstOrDefault();
            var y = (from name in entity.Users
                     where name.Email == email
                     && name.Password == password
                     select name.Name).FirstOrDefault();
            var g = (from name in entity.Users
                     where name.Email == email
                     && name.Password == password
                     select name.Gender).FirstOrDefault();
            var z = (from name in entity.Users
                     where name.Email == email
                     && name.Password == password
                     select name.Email).FirstOrDefault();

            if (x == null)
            {
                LblError.Text = "Salah Email / Salah Password";
            }
            else
            {
                if (x.Status == "blocked")
                {
                    LblError.Text = "Anda di Banned oleh Administrator";
                }
                else
                {
                    Session["user"] = x;
                    if (CBRememberMe.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("user", x.Id.ToString());
                        Response.Cookies["email1"].Value = TBEmail.Text;
                        Response.Cookies["password1"].Value = TBPassword.Text;
                        Response.Cookies["email1"].Expires = DateTime.Now.AddHours(1);
                        Response.Cookies["password1"].Expires = DateTime.Now.AddHours(1);
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        Response.Cookies["email1"].Expires = DateTime.Now.AddHours(-1);
                        Response.Cookies["password1"].Expires = DateTime.Now.AddHours(-1);
                    }
                    LblError.Text = "Sukses";
                    Session["username"] = y;
                    Session["email"] = z;
                    Session["gender"] = g;
                    Response.Redirect("Home2.aspx");
                }
            }
        }

        protected void btnBackGuest_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home1.aspx");
        }
    }
}