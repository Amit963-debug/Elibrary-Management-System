using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ELibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((string)Session["role"]))
                {
                    LinkButton4.Visible = true;
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;
                    LinkButton6.Visible = true;
                    LinkButton3.Visible = false;
                    LinkButton7.Visible = false;
                    LinkButton5.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton11.Visible = false;


                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton4.Visible = true;                                         //view book
                    LinkButton1.Visible = false;                                       //user login
                    LinkButton2.Visible = false;                                      // sign up
                    LinkButton6.Visible = true;                                      // Admin login
                    LinkButton3.Visible = true;                                     // logout
                    LinkButton7.Visible = true;                                     // hello user
                    LinkButton7.Text = "Hello"+ Session["username"].ToString();    // hello user
                    LinkButton5.Visible = false;                                  //Author Management
                    LinkButton8.Visible = false;                                 // publisher management
                    LinkButton9.Visible = false;                                //book inventory
                    LinkButton10.Visible = false;                              // book issuing
                    LinkButton11.Visible = false;                             //Member management

                }
                else if(Session["role"].Equals("admin"))
                {
                    LinkButton4.Visible = true;                                         //view book
                    LinkButton1.Visible = false;                                       //user login
                    LinkButton2.Visible = false;                                      // sign up
                    LinkButton6.Visible = false;                                      // Admin login
                    LinkButton3.Visible = true;                                     // logout
                    LinkButton7.Visible = true;                                     // hello user
                    LinkButton7.Text = "Hello Admin";                             
                    LinkButton5.Visible = true;                                  //Author Management
                    LinkButton8.Visible = true;                                 // publisher management
                    LinkButton9.Visible = true;                                //book inventory
                    LinkButton10.Visible = true;                              // book issuing
                    LinkButton11.Visible = true;                             //Member management

                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublisherrmanagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("userviewbook.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton4.Visible = true;
            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
            LinkButton6.Visible = true;
            LinkButton3.Visible = false;
            LinkButton7.Visible = false;
            LinkButton5.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;
            LinkButton11.Visible = false;

            Response.Redirect("Homepage.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");

        }
    }
}