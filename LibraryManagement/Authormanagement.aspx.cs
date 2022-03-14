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
    public partial class Authormanagement : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //Add Button
        protected void Button1_Click(object sender, EventArgs e)
        {
          if(CheckAuthorID())
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Author ID already exist','error')", true);
            }
            else
            {
                try
                {
                    SqlConnection sqlconnection = new SqlConnection(strconnection);
                    if (sqlconnection.State == ConnectionState.Closed)
                    {
                        sqlconnection.Open();
                    }
                    string query = "INSERT INTO Author_Table (Author_ID,Author_name)VALUES('" + TextBox1.Text.Trim() + "','" + TextBox3.Text.Trim() + "');";
                    SqlCommand command = new SqlCommand(query, sqlconnection);
                    command.ExecuteNonQuery();
                    sqlconnection.Close();
                   
                    GridView1.DataBind();
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Welldone!','Author added Successfully','success')", true);
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            clearform();
            
        }
        //Update
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (CheckAuthorID())
            {
                
                updateauthor();
                GridView1.DataBind();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Welldone!','Author Updated Successfully','success')", true);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Author Does not exist','error')", true);
            }
            clearform();
       
        }
        //Delete
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (CheckAuthorID())
            {
                deleteauthor();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Welldone!','Author Deleted Successfully','success')", true);
                GridView1.DataBind();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Wrong info!','Author Does not exist!','error')", true);
            }
            clearform();
            GridView1.DataBind();
        }
        //GO
        protected void Button2_Click(object sender, EventArgs e)
        {
            getauthorbyid();
        }
        //user Defined Functions
        void updateauthor()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "UPDATE Author_Table SET Author_name='"+TextBox3.Text.Trim()+"'WHERE Author_ID='"+TextBox1.Text+"'";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                command.ExecuteNonQuery();
              
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deleteauthor()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "DELETE FROM Author_Table WHERE Author_ID='" + TextBox1.Text + "'";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                command.ExecuteNonQuery();
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void getauthorbyid(){
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From Author_Table Where Author_ID='" + TextBox1.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable userdatatable = new DataTable();
                dataAdapter.Fill(userdatatable);
                
                if (userdatatable.Rows.Count >= 1)
                {
                    TextBox3.Text = userdatatable.Rows[0][1].ToString();
                }
                else
                {

                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Author ID is not correct!','error')", true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool CheckAuthorID()
        {

            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From Author_Table Where Author_ID='" + TextBox1.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable userdatatable = new DataTable();
                dataAdapter.Fill(userdatatable);
               
                if (userdatatable.Rows.Count >= 1)
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
        void clearform()
        {
            TextBox1.Text = "";
            TextBox3.Text = "";
        }
    }
}