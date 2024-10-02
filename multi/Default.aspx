<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 97%;
            height: 250px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 404px;
        }
    </style>
</head>
<body style="width: 552px; height: 299px">
    <form id="form1" runat="server">
        <div class="auto-style2">
            Login</div>
        <table class="auto-style1" style="background-color: #C0C0C0; border: medium solid #800000">
            <tr>
                <td class="auto-style2">UserName</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="33px" Width="273px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="270px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="30px" Text="Forgot Passsword" />
&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Height="29px" OnClick="Button3_Click" Text="SignUp" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
