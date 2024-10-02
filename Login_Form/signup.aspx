<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 613px;
            border-collapse: collapse;
            z-index: auto;
            height: 210px;
            top: auto;
            right: auto;
            bottom: auto;
            left: auto;
            cursor: auto;
            table-layout: auto;
            border-left-style: solid;
            border-left-width: 1px;
            border-right: 1px solid #C0C0C0;
            border-top-style: solid;
            border-top-width: 1px;
            border-bottom: 1px solid #C0C0C0;
            background-color: #C0C0C0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1" style="font-size: large; font-weight: bolder; vertical-align: middle; text-align: center; letter-spacing: normal; border-collapse: collapse">
                <tr>
                    <td colspan="2">SignUp</td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="43px" Width="329px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="42px" Width="328px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Height="44px" Width="333px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SignUp" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" PostBackUrl="~/login.aspx" Text="Login Here" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
