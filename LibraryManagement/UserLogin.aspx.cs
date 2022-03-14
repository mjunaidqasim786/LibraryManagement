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
    public partial class UserLogin : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usersignup.aspx");
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
                string query = "Select * From Member_Table Where Member_ID='" + TextBox1.Text.Trim() + "'and Password='" + TextBox2.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                       
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Exxcellent!','Login Successful!','Success')", true);
                        Session["username"] = sqlDataReader.GetValue(8).ToString();
                        Session["fullname"] = sqlDataReader.GetValue(0).ToString();
                        Session["role"] = "user";
                        Session["status"] = sqlDataReader.GetValue(10).ToString();
                       
                    }
                    Response.Redirect("Default.aspx");
                }
                else
                {
                 
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Invalid UserName Or Password!','error')", true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
           
            }
        }
     
    }
}