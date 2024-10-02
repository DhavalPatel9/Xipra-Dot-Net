using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        userBAL uBAL = new userBAL();
        uBAL.name = TextBox1.Text;
        uBAL.email = TextBox2.Text;
        uBAL.password = TextBox3.Text;
        uBAL.rdt = Convert.ToDateTime(System.DateTime.Now);
        userDAL uDAL = new userDAL();
        int rval = uDAL.insert_for_signup(uBAL);
        if (rval == 1) 
            {
            Response.Write("<script>alert('Account created successfully')</script>");
            }
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
            }

    
}