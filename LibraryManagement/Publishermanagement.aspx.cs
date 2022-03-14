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
    public partial class Publishermanagement : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //user Defined Functions
        void updatePublisher()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "UPDATE Publisher_Table SET Publisher_name='" + TextBox3.Text.Trim() + "'WHERE Publisher_ID='" + TextBox1.Text.Trim() + "'";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deletePublisher()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "DELETE FROM Publisher_Table WHERE Publisher_ID='" + TextBox1.Text + "'";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                command.ExecuteNonQuery();
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void getPublisherbyid()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From Publisher_Table Where Publisher_ID='" + TextBox1.Text.Trim() + "';";
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
                   
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Invalid Publisher ID!','warning')", true);
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool CheckPublisherID()
        {

            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From Publisher_Table Where Publisher_ID='" + TextBox1.Text.Trim() + "';";
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (CheckPublisherID())
            {
               
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Publisher ID Already Exists Try An other One','warning')", true);
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
                    string query = "INSERT INTO Publisher_Table (Publisher_ID,Publisher_name)VALUES('" + TextBox1.Text.Trim() + "','" + TextBox3.Text.Trim() + "');";
                    SqlCommand command = new SqlCommand(query, sqlconnection);
                    command.ExecuteNonQuery();
                    sqlconnection.Close();
                 
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Excellent!','Publisher Added Sucessfully!','Success')", true);
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            clearform();
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            if (CheckPublisherID())
            {
               
                updatePublisher();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Excellent!','Publisher Updated Sucessfully!','Success')", true);
                GridView1.DataBind();
            }
            else
            {

                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Publisher Does not Exist','warning')", true);
            }
            clearform();
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            if (CheckPublisherID())
            {
                deletePublisher();
               
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Excellent!','Publisher Deleted Sucessfully!','Success')", true);
                GridView1.DataBind();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "Swal.fire('Invalid Information','Publisher Does not Exist','warning')", true);
            }
            clearform();
            GridView1.DataBind();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            getPublisherbyid();
        }
    }
}