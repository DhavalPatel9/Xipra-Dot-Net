using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changepass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"]==null)
        {
            Response.Redirect("login.aspx");
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        regbal rbal = new regbal();
      
        rbal.email = Session["email"].ToString();
      
        if (TextBox1.Text != Session["password"].ToString())
        {
            Response.Write("<script>alert('Old password is incorrect. જુનો ખાનગી શબ્દ ખોટો છે!!!')</script>");
            return;
        }
        rbal.password = TextBox2.Text;
        if (TextBox2.Text != TextBox3.Text)
        {
            Response.Write("<script>alert('New password and confirm password do not match.')</script>");
            return;
        }
        if (TextBox2.Text.Length < 5)
        {
            Response.Write("<script>alert('Password must be at least 5 characters long.')</script>");
            return;
        }

        regdal rdal = new regdal();
            int rval = rdal.update(rbal);
            if (rval == 1)
            {
                Response.Write("<script>alert('Data Updated Successfully, પાસવર્ડ સફળતાપુર્વક અદ્યતન થયો')</script>");
            }

        

        else
        {

            Response.Write("<script>alert('Update Failed. અદ્યતન નિષ્ફળ.')</script>");
        }
    }
}