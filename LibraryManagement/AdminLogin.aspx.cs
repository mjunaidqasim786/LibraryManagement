using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From Admin_Login_Table Where Username='" + TextBox1.Text.Trim() + "'and Password='" + TextBox2.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                     
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Welldone!','Login Successful!','success')", true);
                        Session["username"] = sqlDataReader.GetValue(0).ToString();
                        Session["fullname"] = sqlDataReader.GetValue(2).ToString();
                        Session["role"] = "admin";
                    }
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','You Entered wrong username or Password','error')", true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
    }
}