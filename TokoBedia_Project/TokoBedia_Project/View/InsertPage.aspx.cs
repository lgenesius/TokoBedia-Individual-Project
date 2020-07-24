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
    public partial class InsertPage : System.Web.UI.Page
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = TBProductName.Text.ToString();
            int stock = Int32.Parse(TBProductStock.Text.ToString());
            int price = Int32.Parse(TBProductPrice.Text.ToString());
            int typeid = Int32.Parse(TBProductTypeId.Text.ToString());

            if (stock >= 1)
            {
                if(price>1000 && price%1000 == 0)
                {
                    if (DataRepository.checkProductTypeId(typeid) != null)
                    {
                        if(DataRepository.checkProductName(name)== null)
                        {
                            DataRepository.insertProduct(name, stock, price, typeid);
                            LblErrorInsert.Text = "Success";
                        }
                        else
                        {
                            LblErrorInsert.Text = "Nama Produk sudah ada di Database";
                        }
                        
                    }
                    else
                    {
                        LblErrorInsert.Text = "Tidak ada Product Type Id tersebut di Database Product Type";
                    }
                }
                else
                {
                    LblErrorInsert.Text = "Harga harus melebihi 1000 dan merupakan multiply dari 1000!";
                }
            }
            else
            {
                LblErrorInsert.Text = "Jumlah Stock harus sama dengan satu atau melebihi satu!";
            }
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
    }
}