using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton2.Visible = true;//user login
                    LinkButton3.Visible = true;//sign up
                    LinkButton6.Visible = true;//admin login

                    LinkButton4.Visible = false;//logout
                    LinkButton5.Visible = false;//hello user
                    LinkButton7.Visible = false;//author mng
                    LinkButton8.Visible = false;//publisher mng
                    LinkButton9.Visible = false;//book inventory
                    LinkButton10.Visible = false;//book issueing
                    LinkButton11.Visible = false;//member mng

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton4.Visible = true;//logout
                    LinkButton5.Visible = true;//hello user
                    LinkButton5.Text = "Hello " + Session["fullname"].ToString() +" (Click Here)";
                    LinkButton6.Visible = true;//admin login


                    LinkButton2.Visible = false;//user login
                    LinkButton3.Visible = false;//sign up
                    LinkButton7.Visible = false;//author mng
                    LinkButton8.Visible = false;//publisher mng
                    LinkButton9.Visible = false;//book inventory
                    LinkButton10.Visible = false;//book issueing
                    LinkButton11.Visible = false;//member mng
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton4.Visible = true;//logout
                    LinkButton5.Visible = true;//hello user
                    LinkButton5.Text = "Hello Admin";
                    LinkButton6.Visible = false;//admin login


                    LinkButton2.Visible = false;//user login
                    LinkButton3.Visible = false;//sign up
                    LinkButton7.Visible = true;//author mng
                    LinkButton8.Visible = true;//publisher mng
                    LinkButton9.Visible = true;//book inventory
                    LinkButton10.Visible = true;//book issueing
                    LinkButton11.Visible = true;//member mng
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Authormanagement.aspx");

        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Publishermanagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bookinventory.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bookissueing.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Membermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Viewbooks.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Userlogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usersignup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";
            LinkButton2.Visible = true;//user login
            LinkButton3.Visible = true;//sign up
            LinkButton6.Visible = true;//admin login

            LinkButton4.Visible = false;//logout
            LinkButton5.Visible = false;//hello user
            LinkButton7.Visible = false;//author mng
            LinkButton8.Visible = false;//publisher mng
            LinkButton9.Visible = false;//book inventory
            LinkButton10.Visible = false;//book issueing
            LinkButton11.Visible = false;//member mng
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }
    }
}