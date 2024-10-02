using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class forgotpass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["email"] == null)
        //{
        //    Response.Redirect("login.aspx");
        //}

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        regbal rbal = new regbal();

        //rbal.email = Session["email"].ToString();
        rbal.email = TextBox2.Text;

        Session["email"] = TextBox2.Text;
        
        regdal rdal = new regdal();
        rdal.ds = rdal.forgot(rbal);

        if (rdal.ds.Tables[0].Rows.Count>0)
            {
            Session["email"]=rdal.ds.Tables[0].Rows[0]["email"].ToString();
            Session["id"] = rdal.ds.Tables[0].Rows[0]["regid"].ToString();
            string otp = GenerateOtp();
            Session["otp"]=otp;
            

            SendOtpEmail(rdal.ds.Tables[0].Rows[0]["email"].ToString(), otp);

            Response.Write("<script>alert('OTP generated successfully.');</script>");
        }
        else
        {

            Response.Write("<script>alert('Invalid login details')</script>");

        }
    }
    private string GenerateOtp()
    {
        Random rand = new Random();
        return rand.Next(100000, 999999).ToString();
    }

    private void SendOtpEmail(string toEmail, string otp)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("dhavallspattel18@gmail.com");
        mail.To.Add(toEmail);
        mail.Subject = "Your OTP Code";
        mail.Body = "Your OTP code is : " + otp;

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("dhavallspattel18@gmail.com", "hjxi pfxn jmuq bwlu"),
            EnableSsl = true,
        };

        try
        {
            smtpClient.Send(mail);
            Console.WriteLine("OTP sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to send OTP: {ex.Message}");
        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {

        string enteredOtp = TextBox3.Text;
        string sessionOtp = Session["otp"] != null ? Session["otp"].ToString() : null;

        if (enteredOtp == sessionOtp)
        {
            Response.Write("<script>alert('OTP verified successfully')</script>");
            Response.Redirect("resetpass.aspx");

        }
        else
        {
            Response.Write("<script>alert('Invalid OTP. Please try again.');</script>");
        }
    }
}


