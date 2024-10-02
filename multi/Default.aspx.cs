using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;

    void mycon()
    {

        con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Desktop\\multi\\App_Data\\Database.mdf;Integrated Security=True");
   
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon();
        cmd = new SqlCommand("select * from userdata where user = @un and pass=@ps ", con);

        cmd.Parameters.AddWithValue("@un", TextBox2.Text);
        cmd.Parameters.AddWithValue("@ps", TextBox3.Text);

        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["user"] = ds.Tables[0].Rows[0]["user"].ToString();
            Session["id"] = ds.Tables[0].Rows[0]["id"].ToString();

            Response.Write("<script>alert('Login Success'); window.location.href='logined.aspx';</script>");
        }

        else
        {
            if (TextBox3.Text.Length < 5)
            {
                Response.Write("<script>alert('Password must be at least 5 characters long.');</script>");
                return;
            }
            Response.Write("<script>alert('Invalid login detail')</script>");

        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Write("<script> window.location.href='reg.aspx';</script>");
    }
}