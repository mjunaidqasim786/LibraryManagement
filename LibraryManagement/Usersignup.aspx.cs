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
    public partial class Usersignup : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(CheckUserID())
            {
        
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','User ID already Exists Try Another One','warning')", true);
            }
            else
            {
                sign_upuser();
            }
           
           
        }
        //Check User ID
        bool CheckUserID()
        {
          
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From Member_Table Where Member_ID='"+TextBox8.Text.Trim()+"';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable userdatatable = new DataTable();
                dataAdapter.Fill(userdatatable);
                sqlconnection.Close();
                if (userdatatable.Rows.Count >=1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
            
        }



        //SignUP user Function;
        void sign_upuser()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "INSERT INTO Member_Table (Full_Name,Date_Of_Birth,Contact_Number,Email,State,City,Pin_Code,Full_Address,Member_ID,Password,Account_Status)VALUES('" + TextBox1.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "','" + DropDownList1.SelectedValue.Trim() + "','" + TextBox6.Text.Trim() + "','" + TextBox7.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox8.Text.Trim() + "','" + TextBox9.Text.Trim() + "','Pending');";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                command.ExecuteNonQuery();
                sqlconnection.Close();
             
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Excellent!','Sign Up Sucessful. Go to User Login To Login','Success')", true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
   
}
