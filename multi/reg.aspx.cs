using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reg : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;

    void mycon()
    {
        con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|datadirectory|\\Database.mdf; Integrated Security = True");
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon();

        cmd = new SqlCommand("select * from userdata where user = @um ", con);

        cmd.Parameters.AddWithValue("@um", TextBox1.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Write("<script>alert('this User is already exist...')</script>");
        }
        else
        {
            if (TextBox2.Text.Length < 5)
            {
                Response.Write("<script>alert('Password must be at least 5 characters long.');</script>");
                return;
            }

            cmd = new SqlCommand("Insert into userdata values(@um,@pass,@rdt)", con);
            cmd.Parameters.AddWithValue("@um", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            cmd.Parameters.AddWithValue("@rdt", System.DateTime.Now.ToString());
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('Registration Successfully'); window.location.href='Default.aspx';</script>");

            con.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script> window.location.href='Default.aspx';</script>");

    }
}
