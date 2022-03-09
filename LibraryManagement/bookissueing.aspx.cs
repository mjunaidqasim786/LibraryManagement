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
    public partial class bookissueing : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //go
        protected void Button5_Click(object sender, EventArgs e)
        {
              getBookmembername();
        }

        //issue
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(checkbookexist() && checkmemberexist())
            {
                if(checkissueentryexist())
                {
                    Response.Write("<script>alert('This book is already issued to this member You Can not Issue same book to same member two Times! ');</script>");
                }
                else
                {
                     issuebook();
                }
                
            }
            else
            {
                Response.Write("<script>alert('Wrong Member ID or Book ID');</script>");
            }
        }
        //return
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkbookexist() && checkmemberexist())
            {
                if (checkissueentryexist())
                {
                    returnbook();
                    
                }
                else
                {
                    Response.Write("<script>alert('This Entry Does Not Exists');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Wrong Member ID or Book ID');</script>");
            }
        }
        

        //function

        void getBookmembername()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "SELECT BOOK_NAME FROM BOOK_TABLE WHERE Book_ID='" + TextBox4.Text.Trim() + "';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
                {
                    TextBox1.Text = dataTable.Rows[0]["Book_Name"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Book Id');</script>");
                }
                string query2 = "SELECT Full_NAME FROM Member_Table WHERE Member_ID='"+TextBox2.Text.Trim()+"';";
               sqlCommand = new SqlCommand(query2, sqlconnection);
                dataAdapter = new SqlDataAdapter(sqlCommand);
               dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
                {
                    TextBox3.Text = dataTable.Rows[0]["Full_Name"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Member Id');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkbookexist()
        {

            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "SELECT * FROM BOOK_TABLE WHERE Book_ID='" + TextBox4.Text.Trim() + "' AND Current_stock> 0;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
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
        bool checkmemberexist()
        {

            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "SELECT Full_NAME FROM Member_Table WHERE Member_ID='" + TextBox2.Text.Trim() + "';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
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
        void issuebook()
        {
            try
            {
                if (TextBox3.Text == "" || TextBox1.Text == "")
                {
                    Response.Write("<script>alert('Enter Member ID And Book ID And Click Go Button');</script>");
                }
                else
                {
                    SqlConnection sqlconnection = new SqlConnection(strconnection);
                    if (sqlconnection.State == ConnectionState.Closed)
                    {
                        sqlconnection.Open();
                    }
                    string query = "INSERT INTO Book_Issue_Table (Member_ID,Member_Name,Book_ID,Book_Name,Issue_Date,Due_Date)VALUES('" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox1.Text.Trim() + "','" + TextBox5.Text.Trim() + "','" + TextBox6.Text.Trim() + "');";
                    SqlCommand command = new SqlCommand(query, sqlconnection);
                    command.ExecuteNonQuery();

                    string query2 = "UPDATE Book_Table SET Current_Stock=Current_Stock-1 WHERE Book_ID='" + TextBox4.Text.Trim() + "';";
                    command = new SqlCommand(query2, sqlconnection);
                    command.ExecuteNonQuery();

                    sqlconnection.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('BOOK Issued Successfully');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkissueentryexist()
        {

            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "SELECT * FROM Book_Issue_Table WHERE Member_ID='" + TextBox2.Text.Trim() + "'  AND BOOK_ID='" + TextBox4.Text.Trim() + "';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count >= 1)
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
        void returnbook()
        {
            try
            {
                if (TextBox3.Text == "" || TextBox1.Text == "")
                {
                    Response.Write("<script>alert('Enter Member ID And Book ID And Click Go Button');</script>");
                }
                else
                {
                    SqlConnection sqlconnection = new SqlConnection(strconnection);
                    if (sqlconnection.State == ConnectionState.Closed)
                    {
                        sqlconnection.Open();
                    }
                    string query = "Delete From Book_Issue_Table WHERE Member_ID='" + TextBox2.Text.Trim() + "'  AND BOOK_ID='" + TextBox4.Text.Trim() + "';";
                    SqlCommand command = new SqlCommand(query, sqlconnection);
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        string query2 = "UPDATE Book_Table SET Current_Stock=Current_Stock+1 WHERE Book_ID='" + TextBox4.Text.Trim() + "';";
                        command = new SqlCommand(query2, sqlconnection);
                        command.ExecuteNonQuery();
                        Response.Write("<script>alert('BOOK Returned Successfully');</script>");
                    }
                    

                    sqlconnection.Close();
                    GridView1.DataBind();
                   
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
              if( e.Row.RowType==DataControlRowType.DataRow)
                {
                    DateTime dateTime = Convert.ToDateTime(e.Row.Cells[5].Text);

                   if(DateTime.Today > dateTime)
                    {
                        e.Row.BackColor = System.Drawing.Color.PaleVioletRed;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
        
    }
