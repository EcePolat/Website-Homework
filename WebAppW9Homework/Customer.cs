using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppW9Homework
{
    public partial class SignUp : System.Web.UI.Page
    {
        public int InsertCustomer(string getName, string getSurname, string getGender, string getUserName, string getPassword, string getAddress, string getPhoneNumber, string getEmail, string getBirthday)
        {
            int result = 0;
            string constr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=eCommerceWebsite;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Customer ( Name,Surname,Gender,UserName,Password,Address,PhoneNumber,Email,Birthday)" + "VALUES('" + getName + "','" + getSurname + "','" + getGender + "','" + getUserName + "','" + getPassword + "','" + getAddress + "','" + getPhoneNumber + "','" + getEmail + "','" + getBirthday + "')", con);
                result = command.ExecuteNonQuery();
            }
            return result;
        }
    }
    public partial class Login : System.Web.UI.Page
    {
        private void ControlData()
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                Label.Text = "User name or Password cannot be left blank. ";
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=eCommerceWebsite;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter User = new SqlDataAdapter();
            SqlCommand selectUser = new SqlCommand("SELECT UserName, Password FROM Customer WHERE UserName=@UserName");
            selectUser.Connection = connection;
            selectUser.Parameters.AddWithValue("@UserName", txtUserName.Text);
            User.SelectCommand = selectUser;
            DataSet UserDS = new DataSet();
            UserDS.Clear();
            User.Fill(UserDS);
            if (UserDS.Tables[0].Rows.Count == 0)
            {
                Label.Text = "The user cannot be found.";
                
                return;
            }
            string uPassword = UserDS.Tables[0].Rows[0]["Password"].ToString();

            if ( uPassword == txtPassword.Text)
            {
                
                    if (remember.Checked)
                    {
                        Response.Cookies["UserName"].Value = txtUserName.Text;
                        Response.Cookies["Password"].Value = txtPassword.Text;
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(1);
                        Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(1);
                        connection.Close();
                    }
                    else
                    {
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(-1);
                        Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);
                    }

                    Response.Redirect("Home.html");
                
            }
            else
            {
                Label.Text = "Your password is incorrect.";
            }
        }
    }
}