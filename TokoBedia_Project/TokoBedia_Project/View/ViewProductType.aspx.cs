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
    public partial class ViewProductType : System.Web.UI.Page
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
            loadgrid();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home2.aspx");
        }

        protected void loadgrid()
        {
            TokoBediaDatabaseEntities db = new TokoBediaDatabaseEntities();
            var query = from m in db.ProductTypes
                        select new
                        {
                            ProductTypeId = m.ProductType_Id,
                            ProductTypeName = m.ProductType_Name,
                            ProductTypeDescription = m.ProductType_Description
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = TBDelete.Text.ToString();
            if(DataRepository.checkUpdateProductType(name) != null)
            {
                DataRepository.removeProductType(name);
                loadgrid();
                LblError.Text = "Success Delete!";
            }
            else
            {
                LblError.Text = "Nama Product Type tersebut tidak ada di Database";
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertTypePage.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateTypePage.aspx");
        }
    }
}