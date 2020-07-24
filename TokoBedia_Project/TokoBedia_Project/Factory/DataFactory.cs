using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_Project.Model;

namespace TokoBedia_Project.Factory
{
    public class DataFactory
    {
        public static User createUser(string email, string name, string password, string gender, string status, int role_id)
        {
            User user= new User();
            user.Role_Id = role_id;
            user.Email = email;
            user.Name = name;
            user.Password = password;
            user.Gender = gender;
            user.Status = status;
            return user;
        }

        public static Product createProduct(string name, int stock, int price, int typeid)
        {
            Product product = new Product();
            product.Product_Name = name;
            product.Product_Stock = stock;
            product.Product_Price = price;
            product.ProductType_Id = typeid;
            return product;
        }

        public static ProductType createProductType(string name, string description)
        {
            ProductType producttype = new ProductType();
            producttype.ProductType_Name = name;
            producttype.ProductType_Description = description;
            return producttype;
        }
    }
}