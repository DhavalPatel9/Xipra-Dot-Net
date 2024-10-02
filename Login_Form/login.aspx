<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 61%;
            border-collapse: collapse;
            z-index: auto;
            cursor: auto;
            table-layout: auto;
            background-color: #CCFF66;
        }
        .auto-style2 {
            width: 677px;
        }
        .auto-style3 {
            font-size: medium;
        }
        .auto-style4 {
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="font-size: x-large; font-weight: bolder; line-height: normal; text-align: center; padding: 10px; border-collapse: separate; vertical-align: middle; word-spacing: normal; letter-spacing: normal; z-index: auto; cursor: auto; table-layout: auto;">
                <tr>
                    <td colspan="2">Login</td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="41px" Width="331px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="45px" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
                        <a href="forgotpass.aspx">Forgot password</a>
                        <br />
                        <br />
                        <span class="auto-style4">Not Having Account&nbsp;&nbsp; <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/signup.aspx">Click Here</asp:HyperLink>
                        <br />
                        </span></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
