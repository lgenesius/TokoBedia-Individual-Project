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
    public partial class UpdatePage : System.Web.UI.Page
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
            var query = from g in db.Products
                        join m in db.ProductTypes on g.ProductType_Id equals m.ProductType_Id
                        select new
                        {
                            ProductId = g.Product_Id,
                            ProductName = g.Product_Name,
                            ProductStock = g.Product_Stock,
                            ProductTypeName = m.ProductType_Name,
                            ProductPrice = g.Product_Price
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = TBProductName.Text.ToString();
            int stock = Int32.Parse(TBProductStock.Text.ToString());
            int price = Int32.Parse(TBProductPrice.Text.ToString());

            if (stock >= 1)
            {
                if (price > 1000 && price % 1000 == 0)
                {
                    if (DataRepository.checkUpdateProduct(name)!=null)
                    {
                        DataRepository.updateProduct(name, stock, price);
                        loadgrid();
                        LblErrorUpdate.Text = "Success Update!";
                    }
                    else
                    {
                        LblErrorUpdate.Text = "Tidak ada Product Name tersebut di Database!";
                    }
                    
                }
                else
                {
                    LblErrorUpdate.Text = "Harga harus melebihi 1000 dan merupakan multiply dari 1000!";
                }
            }
            else
            {
                LblErrorUpdate.Text = "Jumlah Stock harus sama dengan satu atau melebihi satu!";
            }
        }
    }
}