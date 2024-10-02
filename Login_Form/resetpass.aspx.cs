using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class resetpass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        regbal rbal = new regbal();
        string em = Session["email"].ToString();
        rbal.email = em;
        rbal.password=TextBox1.Text;

        regdal rdal = new regdal();
        int rval=rdal.reset(rbal);

        if(TextBox1.Text==TextBox2.Text)
        {
           
            Response.Write("<script>alert('Password changed.  ખાનગી શબ્દ બદલાયેલ છે.!! '); window.location.href='login.aspx';</script>");

        }
        else
        {
            Response.Write("<script>alert('Invalid detail.ખોટી  માહિતિ')</script>");

        }
    }
}
