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
    public partial class UpdateTypePage : System.Web.UI.Page
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = TBProductTypeName.Text.ToString();
            string description = TBProductDescription.Text.ToString();

            if(name.Length >= 5)
            {
                if (DataRepository.checkUpdateProductType(name)!= null)
                {
                    DataRepository.updateProductType(name, description);
                    loadgrid();
                    LblErrorUpdate.Text = "Success Update!";
                }
                else
                {
                    LblErrorUpdate.Text = "Tidak ada nama tipe produk tersebut di database!";
                }
            }
            else
            {
                LblErrorUpdate.Text = "Tipe Produk Nama harus melebihi 5 karakter!";
            }
        }
    }
}