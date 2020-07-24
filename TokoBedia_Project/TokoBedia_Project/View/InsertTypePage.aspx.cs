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
    public partial class InsertTypePage : System.Web.UI.Page
    {
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
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = TBProductTypeName.Text.ToString();
            string description = TBProductDesc.Text.ToString();

            if(name.Length >= 5)
            {
                if(DataRepository.checkProductTypeName(name) == null)
                {
                    DataRepository.insertProductType(name, description);
                    LblErrorInsert.Text = "Success Insert!";
                }
                else
                {
                    LblErrorInsert.Text = "Nama Tipe Produk tersebut sudah ada di Database !";
                }
            }
            else
            {
                LblErrorInsert.Text = "Panjang Nama harus sama dengan atau lebih dari 5 !";
            }
        }
    }
}