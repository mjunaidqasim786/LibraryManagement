using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class UserProfile : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {   try
            {
                if (Session["username"].ToString() == "" || Session["username"].ToString() == "")
                {
                   
                }
                else
                {
                    getusersbookdata();
                    if (!Page.IsPostBack)
                    {
                        getuserdata();
                    }
                }
            }
            catch
            {
                
                Response.Redirect("userlogin.aspx");
            }
        }
        //update
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == "" || Session["username"].ToString() == "")
            {

            }
            else
            {
                updateuserdata();
            }
        }



        //functions
        void getusersbookdata()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From book_issue_Table Where Member_ID='" + Session["username"].ToString() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable userdatatable = new DataTable();
                dataAdapter.Fill(userdatatable);
                GridView1.DataSource = userdatatable;
                GridView1.DataBind();

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
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    DateTime dateTime = Convert.ToDateTime(e.Row.Cells[5].Text);

                    if (DateTime.Today > dateTime)
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
        void getuserdata()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "Select * From member_Table Where Member_ID='" + Session["username"].ToString() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable userdatatable = new DataTable();
                dataAdapter.Fill(userdatatable);
                TextBox1.Text = userdatatable.Rows[0]["Full_Name"].ToString();
                TextBox3.Text = userdatatable.Rows[0]["Date_Of_Birth"].ToString();
                TextBox4.Text = userdatatable.Rows[0]["Contact_Number"].ToString();
                TextBox5.Text = userdatatable.Rows[0]["Email"].ToString();
                DropDownList1.SelectedValue = userdatatable.Rows[0]["State"].ToString().Trim();
                TextBox6.Text = userdatatable.Rows[0]["City"].ToString();
                TextBox7.Text = userdatatable.Rows[0]["Pin_Code"].ToString();
                TextBox2.Text = userdatatable.Rows[0]["Full_Address"].ToString();
                TextBox8.Text = userdatatable.Rows[0]["Member_ID"].ToString();
                TextBox9.Text = userdatatable.Rows[0]["Password"].ToString();
                Label1.Text = userdatatable.Rows[0]["Account_Status"].ToString().Trim();


                if (userdatatable.Rows[0]["Account_Status"].ToString().Trim() == "Active")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-success");
                }
               else if (userdatatable.Rows[0]["Account_Status"].ToString().Trim() == "Pending")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-warning");
                }
               else if (userdatatable.Rows[0]["Account_Status"].ToString().Trim() == "Deactive")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-danger");
                }
                else
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-secondary");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updateuserdata()
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(strconnection);
                string password;
                if (TextBox10.Text.Trim() == "")
                {
                    password = TextBox9.Text.Trim();
                }
                else
                {
                    password = TextBox10.Text.Trim();
                }

                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                string query = "UPDATE Member_Table set Full_Name='"+TextBox1.Text.Trim()+ "', Date_Of_Birth='" + TextBox3.Text.Trim() + "', Contact_Number='" + TextBox4.Text.Trim() + "',Email='" + TextBox5.Text.Trim() + "', State='" + DropDownList1.SelectedValue.Trim() + "', City='" + TextBox6.Text.Trim() + "', Pin_Code='" + TextBox7.Text.Trim() + "', Full_Address='" + TextBox2.Text.Trim() + "', Password='"+password+ "', Account_Status='Pending' Where Member_ID='" + Session["username"].ToString() + "';";
                SqlCommand command = new SqlCommand(query, sqlconnection);
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                 Response.Write("<script>alert('Your Account Updated Successfully');</script>");
                    getuserdata();
                    getuserdata();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Entry');</script>");
                }
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}