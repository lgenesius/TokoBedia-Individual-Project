using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_Project.Factory;
using TokoBedia_Project.Model;

namespace TokoBedia_Project.Repository
{
    public class DataRepository
    {
        static TokoBediaDatabaseEntities db = new TokoBediaDatabaseEntities();
        public static void registerUser(string email, string name, string password, string gender, string status, int role_id)
        {
            User user = DataFactory.createUser(email, name, password, gender, status, role_id);
            db.Users.Add(user);
            db.SaveChanges();
        }
   
        public static List<User> getAllItem()
        {
            return db.Users.ToList();
        }

        public static User getEmailByUser(string email)
        {
             User e_mail = db.Users.Where(a => a.Email == email).FirstOrDefault();
            return e_mail;
        }

        public static List<Product> getProduct(int generated)
        {
            return db.Products.Where(a => a.Product_Id == generated).ToList();
        }

        public static List<Product> getAllProduct()
        {
            return db.Products.ToList();
        }

        public static void insertProduct(string name, int stock, int price, int typeid)
        {
            Product product = DataFactory.createProduct(name, stock, price, typeid);
            db.Products.Add(product);
            db.SaveChanges();
        }

        public static void insertProductType(string name, string description)
        {
            ProductType producttype = DataFactory.createProductType(name, description);
            db.ProductTypes.Add(producttype);
            db.SaveChanges();
        }

        public static void updateProduct(string name, int stock, int price)
        {
            Product product = db.Products.Where(a => a.Product_Name == name).FirstOrDefault();
            product.Product_Stock = stock;
            product.Product_Price = price;
            db.SaveChanges();
        }

        public static void updateUser(string email, int role_id, string status)
        {
            User user = db.Users.Where(a => a.Email == email).FirstOrDefault();
            user.Role_Id = role_id;
            user.Status = status;
            db.SaveChanges();
        }

        public static void changePassword(int user_id, string newPass)
        {
            User user = db.Users.Where(a => a.Id == user_id).FirstOrDefault();
            user.Password = newPass;
            db.SaveChanges();
        }

        public static void updateProfile(int user_id, string email, string name, string gender)
        {
            User user = db.Users.Where(a => a.Id == user_id).FirstOrDefault();
            user.Email = email;
            user.Name = name;
            user.Gender = gender;
            db.SaveChanges();
        }

        public static void updateProductType(string name, string description)
        {
            ProductType producttype = db.ProductTypes.Where(a => a.ProductType_Name == name).FirstOrDefault();
            producttype.ProductType_Name = name;
            producttype.ProductType_Description = description;
            db.SaveChanges();
        }

        public static Product checkUpdateProduct(string name)
        {
             Product product = db.Products.Where(a => a.Product_Name == name).FirstOrDefault();
            return product;
        }

        public static ProductType checkUpdateProductType(string name)
        {
            ProductType producttype = db.ProductTypes.Where(a => a.ProductType_Name == name).FirstOrDefault();
            return producttype;
        }

        public static ProductType checkProductTypeId(int id)
        {
            ProductType producttype = db.ProductTypes.Where(a => a.ProductType_Id == id).FirstOrDefault();
            return producttype;
        }

        public static Product checkProductName(string name)
        {
            Product product = db.Products.Where(a => a.Product_Name == name).FirstOrDefault();
            return product;
        }

        public static ProductType checkProductTypeName(string name)
        {
            ProductType producttype = db.ProductTypes.Where(a => a.ProductType_Name == name).FirstOrDefault();
            return producttype;
        }

        public static void removeProduct(string name)
        {
            Product product = db.Products.Where(a => a.Product_Name == name).FirstOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public static void removeProductType(string name)
        {
            ProductType producttype = db.ProductTypes.Where(a => a.ProductType_Name == name).FirstOrDefault();
            db.ProductTypes.Remove(producttype);
            db.SaveChanges();
        }

        public static Product checkProductId(int id)
        {
            Product product = db.Products.Where(a => a.Product_Id == id).FirstOrDefault();
            return product;
        }

    }
}