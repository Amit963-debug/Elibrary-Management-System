using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ELibraryManagement
{
    public partial class adminauthormanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfpublisherExist())
            {
                Response.Write("<script>alert('Publisher ID in use. Select other');</script>");

            }
            else
            {
                AddpublisherID();
            }
            clearform();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfpublisherExist())
            {
                updatepublisher();

            }
            else
            {
                Response.Write("<script>alert('publisher doesnot exist');</script>");
            }
            clearform();
            GridView1.DataBind();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfpublisherExist())
            {
                deletepublisher();

            }
            else
            {
                Response.Write("<script>alert('publisher doesnot exist');</script>");
            }
            clearform();
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetpublisherID();
        }
        void GetpublisherID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) ;
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select *from publisher_master_tbl Where publisher_id='" + TextBox1.Text.Trim() + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid ID')</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void clearform()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
        void deletepublisher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) ;
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM publisher_master_tbl  WHERE publisher_id='" + TextBox1.Text.Trim() + "'", con);


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('publisher deleted succesfully.');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void updatepublisher()
        {

            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed) ;
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE publisher_master_tbl SET publisher_name=@publisher_name WHERE publisher_id='" + TextBox1.Text.Trim() + "'", con);
                    cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('publisher updated succesfully.');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                }
            }
        }
        void AddpublisherID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) ;
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into publisher_master_tbl([publisher_id],[publisher_name] )VALUES (@publisher_id,@publisher_name)", con);
                cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('publisher added succesfully.');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        bool checkIfpublisherExist()

        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed) ;
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select *from publisher_master_tbl Where publisher_id='" + TextBox1.Text.Trim() + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count >= 1)
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
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
            return false;
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}
        
