using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebAppW9Homework
{
    public partial class SignUp : System.Web.UI.Page
    {
        private String getName;
        private String getSurname;
        private String getGender;
        private String getUsername;
        private String getPassword;
        private String getAddress;
        private String getPhoneNumber;
        private String getEmail;
        private String getBirthday;
        private bool getIsWantEmailFromUs;

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            getName = txtName.Text.Trim();
            getSurname = txtSurname.Text.Trim();
            getGender = gender.Text.Trim();
            getUsername = txtUserName.Text.Trim();
            getPassword = txtPassword.Text.Trim();
            getAddress = txtAdres.Text.Trim();
            getPhoneNumber = txtPhoneNumber.Text.Trim();
            getEmail = txtEmail.Text.Trim();
            getBirthday = birthday.Text.Trim();
            int result = InsertCustomer(getName, getSurname, getGender, getUsername, getPassword, getAddress, getPhoneNumber, getEmail, getBirthday);
           
            if (result > 0)
            {
                lblMessage.Text = "Registration successful. You will be redirected to home page in 5 seconds.";
                lblMessage.Style.Add("color", "purple");
                MyTable.Style.Add("display", "none");
                Response.AddHeader("REFRESH","5;URL=Home.html");
            }
            else
            {
                lblMessage.Text = "Sorry, your registration attempt was unsuccessful. Please, try again.";
                lblMessage.Style.Add("color", "red");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}