using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokoBedia_Project.View
{
    public partial class StartingHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginForm.aspx");
        }

        protected void btnGoRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterForm.aspx");
        }

        protected void btnGoViewP_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductForGuest.aspx");
        }
    }
}