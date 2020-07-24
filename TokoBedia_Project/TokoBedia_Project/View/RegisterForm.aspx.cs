using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TokoBedia_Project.Repository;

namespace TokoBedia_Project.View
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            LblError2.Text = "";
            string email = registerEmail.Text.ToString();
            string name = registerName.Text.ToString();
            string password = registerPassword.Text.ToString();
            string conPass = confirmPassword.Text.ToString();
            string gender = DDLGender.Text.ToString();
            int role_Id = 2;

            if(DataRepository.getEmailByUser(email)==null)
            {
                if (conPass == password)
                {
                    DataRepository.registerUser(email, name, password, gender, "active", role_Id);
                    LblError2.Text = "Success";
                }
                else
                {
                    LblError2.Text = "Confirm Password Salah!";
                }
            }
            else
            {
                LblError2.Text = "Email sudah ada";
            }
        }
    }
}