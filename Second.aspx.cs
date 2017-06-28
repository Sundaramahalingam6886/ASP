using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Second : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=SUNDAR\SQLEXPRESS;Initial Catalog=company;Integrated Security=True");
        SqlCommand cmd = new SqlCommand("select * from auditor where id between 13 and 24", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView2.DataSource = ds;
        GridView2.DataBind();    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Third.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        

    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}