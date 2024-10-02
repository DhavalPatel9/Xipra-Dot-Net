using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox3.Text.Length < 5)
        {
            Response.Write("<script>alert('Password must be at least 5 characters long.');</script>");
            return; 
        }

        regbal rbal = new regbal();
        rbal.name = TextBox1.Text;
        rbal.email = TextBox2.Text;
        rbal.password = TextBox3.Text;
        rbal.rdt = Convert.ToDateTime(System.DateTime.Now);



        regdal rdal = new regdal();

        int rval = rdal.insert(rbal);

        if (rval== 1)
        {
                Response.Write("<script>alert('Signup successful!');</script>");

        
        }


       
        }
    }
