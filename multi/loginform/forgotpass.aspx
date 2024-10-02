<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgotpass.aspx.cs" Inherits="forgotpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 88%;
            height: 381px;
            border: 1px solid #FFFFFF;
            margin-left: 0px;
            background-color: #33CCFF;
        }
        .auto-style2 {
            height: 50px;
            text-align: center;
        }
        .auto-style4 {
            width: 711px;
            height: 51px;
        }
        .auto-style6 {
            height: 51px;
            text-align: center;
        }
        .auto-style8 {
            height: 51px;
            width: 722px;
        }
        .auto-style9 {
            margin-left: 18px;
        }
        .auto-style10 {
            margin-left: 21px;
        }
        .auto-style11 {
            color: #FFFFFF;
            background-color: #006699;
        }
    </style>
</head>
<body style="width: 1014px; height: 456px; margin-left: 120px">
    <form id="form1" runat="server">
        <div>
            <table align="center" border="0" class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>FORGOT PASSWORD</strong></td>
                </tr>
                <tr>
                    <td class="auto-style4">ENTER YOUR REGISTERED EMAIL</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style9" Height="35px" Width="421px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        <asp:Button ID="Button1" runat="server" BackColor="#006699" BorderColor="Black" CssClass="auto-style11" Height="48px" Text="GENERATE OTP" Width="157px" Style="border-radius:20px"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">VERIFY OTP </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style10" Height="35px" Width="421px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style11" Height="48px" Text="VERIFY" Width="157px" Style="border-radius:20px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/login.aspx">CLICK HERE TO LOGIN</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
