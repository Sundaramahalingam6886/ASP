using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUNDAR\SQLEXPRESS;Initial Catalog=company;Integrated Security=True");
        con.Open();
        SqlCommand cmd=new SqlCommand("insert into auditor values("+TextBox2.Text+",'"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+DropDownList1.SelectedItem+"','"+TextBox7.Text+"','"+RadioButtonList1.SelectedItem+"')",con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script> alert('Registered..!') </Script>");
        //Response.Redirect("sundar.html");
    }
}