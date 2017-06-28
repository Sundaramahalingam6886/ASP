using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUNDAR\SQLEXPRESS;Initial Catalog=company;Integrated Security=True");
        con.Open();
        SqlParameter p1 = new SqlParameter("@u", TextBox1.Text);
        SqlParameter p2 = new SqlParameter("@p", TextBox2.Text);
        //SqlCommand cmd = new SqlCommand("select * from auditor where name='" + TextBox1.Text + "' and passwrd='" + TextBox2.Text + "' ", con);
        SqlCommand cmd = new SqlCommand("storelog", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            Response.Redirect("Success.aspx");

        }
        else
        {
            Response.Write("<script> alert('Invalid Login..!') </script>");
        }
        con.Close();
    }
}