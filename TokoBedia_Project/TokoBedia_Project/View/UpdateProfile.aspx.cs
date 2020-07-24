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
    public partial class UpdateProfile : System.Web.UI.Page
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
            TBEmail.Attributes["placeholder"] = Session["email"].ToString();
            TBName.Attributes["placeholder"] = Session["username"].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = TBEmail.Text.ToString();
            string name = TBName.Text.ToString();
            string gender = TBGender.Text;
            if (DataRepository.getEmailByUser(email) == null)
                {
                    DataRepository.updateProfile(us.Id, email, name, gender);
                    Session["username"] = TBName.Text;
                    Session["email"] = TBEmail.Text;
                    Session["gender"] = TBGender.Text;
                    TBEmail.Attributes["placeholder"] = Session["email"].ToString();
                    TBName.Attributes["placeholder"] = Session["username"].ToString();
                    LblError.Text = "Success Update Profile!";
                }
            else
            {
                if (us.Email == email)
                {
                    DataRepository.updateProfile(us.Id, email, name, gender);
                    Session["username"] = TBName.Text;
                    Session["email"] = TBEmail.Text;
                    Session["gender"] = TBGender.Text;
                    TBEmail.Attributes["placeholder"] = Session["email"].ToString();
                    TBName.Attributes["placeholder"] = Session["username"].ToString();
                    LblError.Text = "Success Update Profile!";
                }
            }
            
        }
    }
}