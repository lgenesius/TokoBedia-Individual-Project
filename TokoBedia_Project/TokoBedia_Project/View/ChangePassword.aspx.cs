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
    public partial class ChangePassword : System.Web.UI.Page
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
        }

        protected void btnGoProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPass = TBOldPass.Text.ToString();
            string newPass = TBNewPass.Text.ToString();
            string confPass = TBConfPass.Text.ToString();

            if(oldPass == us.Password)
            {
                if(newPass.Length > 5)
                {
                    if(newPass == confPass)
                    {
                        DataRepository.changePassword(us.Id, newPass);
                        LblError.Text = "Success!";
                    }
                    else
                    {
                        LblError.Text = "Password baru dan Konfirmasi Password tidak sama!";
                    }
                }
                else
                {
                    LblError.Text = "Password baru harus melebihi 5 jumlah karakter!";
                }
            }
            else
            {
                LblError.Text = "Old Password tidak sesuai dengan yang di Database!";
            }
        }
    }
}