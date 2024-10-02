using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      regBAL rBAL = new regBAL();
        rBAL.name = TextBox1.Text;
        rBAL.email = TextBox2.Text;
        rBAL.password = TextBox3.Text;
        if (RadioButton1.Checked == true)
        {
            rBAL.gender = RadioButton1.Text;

        }
        else
        {
            rBAL.gender = RadioButton2.Text;
        }
        rBAL.city = DropDownList1.SelectedItem.Value;
        if (FileUpload1.HasFile)
        {
            HiddenField2.Value = System.IO.Path.GetFileName(FileUpload1.FileName);
            HiddenField1.Value = Guid.NewGuid().ToString() + HiddenField2.Value;
            FileUpload1.SaveAs(Server.MapPath("~/images" + HiddenField1.Value));
            rBAL.image = "~/images/" + HiddenField2.Value;
        }
        rBAL.regdate = Convert.ToDateTime(System.DateTime.Now);
        regDAL regDAL = new regDAL();
        int rval = rDAl
}