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
    public partial class Membermanagement : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //go
        protected void Button2_Click(object sender, EventArgs e)
        {
            getmemberbyid();
        }
        //warn
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (CheckAuthorID())
            {
                updatememberstatus("Pending");
                GridView1.DataBind();
            }
            else
            {
                
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Invalid Member ID','warning')", true);
            }
        }
      
        //dead
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (CheckAuthorID())
            {
                updatememberstatus("Deactive");
            GridView1.DataBind();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Invalid Member ID','warning')", true);
            }
}
      //Active
        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            if (CheckAuthorID())
            {
                updatememberstatus("Active");
            GridView1.DataBind();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Invalid Member ID','warning')", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckAuthorID()) { 
            deletemember();
            GridView1.DataBind();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Invalid Member ID','warning')", true);
            }
        }
        void getmemberbyid()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From Member_Table Where Member_ID='" + TextBox2.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        TextBox7.Text = sqlDataReader.GetValue(0).ToString();
                        TextBox4.Text = sqlDataReader.GetValue(10).ToString();
                        TextBox10.Text = sqlDataReader.GetValue(1).ToString();
                        TextBox8.Text = sqlDataReader.GetValue(2).ToString();
                        TextBox9.Text = sqlDataReader.GetValue(3).ToString();
                        TextBox11.Text = sqlDataReader.GetValue(4).ToString();
                        TextBox1.Text = sqlDataReader.GetValue(5).ToString();
                        TextBox3.Text = sqlDataReader.GetValue(6).ToString();
                        TextBox5.Text = sqlDataReader.GetValue(7).ToString();
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Invalid Member ID','warning')", true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updatememberstatus(string status)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "UPDATE Member_Table SET Account_Status='" + status + "' Where Member_ID='" + TextBox2.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                command.ExecuteNonQuery();
                sqlconnection.Close();

             
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Excellent!','Member Status is Updated','Success')", true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deletemember()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Delete From Member_Table Where Member_ID='" + TextBox2.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                command.ExecuteNonQuery();
                sqlconnection.Close();

              
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Excellent!','Member is Deleted!','Success')", true);

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
                string query = "Select * From Member_Table Where Member_ID='" + TextBox2.Text.Trim() + "';";
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
    }
}