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
    public partial class ViewProduct : System.Web.UI.Page
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
  
            if(us.Role_Id != 1)
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
                btnGoInsert.Visible = false;
                btnGoUpdate.Visible = false;
                btnGoDelete.Visible = false;
                Label2.Visible = false;
                TBDeleteProduct.Visible = false;
                LblErrorDelete.Visible = false;
                loadgrid2();
            }
            else 
            {
                loadgrid();
            }
            
        }

        protected void btnGoInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPage.aspx");
        }

        protected void btnGoUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePage.aspx");
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

        protected void loadgrid2()
        {
            TokoBediaDatabaseEntities db = new TokoBediaDatabaseEntities();
            List<Product> test = new List<Product>();
            Random rnd = new Random();
            int value1 = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;
            int value5 = 0;
            var v = db.Products.OrderByDescending(t => t.Product_Id).First();
            var d = db.Products.OrderBy(c => c.Product_Id).First();
            int e = GridView1.PageSize;
            do
            {
                value1 = rnd.Next(1, e);
            } while (DataRepository.checkProductId(value1)==null);
            do
            {
                value2 = rnd.Next(1, e);
            } while (DataRepository.checkProductId(value2) == null || value2==value1);
            do
            {
                value3 = rnd.Next(1, e);
            } while (DataRepository.checkProductId(value3) == null || value3 == value1 || value3 == value2);
            do
            {
                value4 = rnd.Next(1, e);
            } while (DataRepository.checkProductId(value4) == null || value4 == value1 || value4 == value2 || value4==value3);
            do
            {
                value5 = rnd.Next(1, e);
            } while (DataRepository.checkProductId(value5) == null || value5 == value1 || value5 == value2 || value5 == value3 || value5==value4);

            var query = from g in db.Products
                        join m in db.ProductTypes on g.ProductType_Id equals m.ProductType_Id
                        where g.Product_Id == value1 || g.Product_Id== value2 || g.Product_Id==value3 || g.Product_Id==value4 || g.Product_Id==value5
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

        protected void btnGoDelete_Click(object sender, EventArgs e)
        {
            string name = TBDeleteProduct.Text.ToString();
            if(DataRepository.checkUpdateProduct(name)!= null)
            {
                DataRepository.removeProduct(name);
                loadgrid();
                LblErrorDelete.Text = "Success Delete!";
            }
            else
            {
                LblErrorDelete.Text = "Tidak ada nama Produk tersebut di Database";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home2.aspx");
        }
    }
}