using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login :  System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        regbal rbal=new regbal();
        rbal.email=TextBox1.Text;
        rbal.password = TextBox2.Text;

        regdal rdal = new regdal();
        rdal.ds = rdal.login(rbal);

        if (rdal.ds.Tables[0].Rows.Count > 0) { 


            Session["email"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;
            Response.Write("<script>alert('Login Success.  પ્રવેશ સફળ!! '); window.location.href='homepage.aspx';</script>");

        }
        else
        {
            if (TextBox2.Text.Length < 5)
            {
                Response.Write("<script>alert('Password must be at least 5 characters long. ખાનગી શબ્દ ૫- શબ્દ થી વધુ નાખો');</script>");
                return;
            }
            Response.Write("<script>alert('Invalid login detail.ખોટી પ્રવેશ માહિતિ')</script>");


        }

    }
    }