using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace college_project
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;

                    LinkButton3.Visible = false;
                    LinkButton7.Visible = false;

                    LinkButton6.Visible = true;
                    LinkButton10.Visible = false;
                }
                else if (Session["role"].Equals("User"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;

                    LinkButton3.Visible = true;
                    LinkButton7.Visible = true;
                    LinkButton7.Text ="" + Session["username"].ToString();



                    LinkButton6.Visible = true;
                    LinkButton10.Visible = false;
                }

                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;

                    LinkButton3.Visible = true;
                    LinkButton7.Visible = true;
                    LinkButton7.Text = "Hello Admin";



                    LinkButton6.Visible = false;
                    LinkButton10.Visible = true;
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginpage.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Login Successful');</script>");
            Session["username"] = "";
            Session["password"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true;
            LinkButton2.Visible = true;

            LinkButton3.Visible = false;
            LinkButton7.Visible = false;

            LinkButton6.Visible = true;
            LinkButton10.Visible = false;
        }

        protected void LinkButton6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("membermanagment.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}