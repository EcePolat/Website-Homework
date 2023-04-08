using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppW9Homework
{
    public partial class Login : System.Web.UI.Page
    {
        private static bool remembered = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
                {
                    Response.Redirect("Home.html");
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string getUserName = txtUserName.Text;
            string getPassword = txtPassword.Text;
            ControlData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");

        }

    }
}