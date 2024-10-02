<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgotpass.aspx.cs" Inherits="forgotpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 69%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
            background-color: #66FF99;
        }
        .auto-style2 {
            height: 24px;
            width: 445px;
        }
        .auto-style3 {
            width: 797px;
        }
        .auto-style4 {
            height: 24px;
            width: 797px;
        }
        .auto-style5 {
            width: 445px;
        }
        .auto-style6 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6" colspan="2">Forgot Password</td>
                </tr>
                <tr>
                    <td class="auto-style5">Enter Your Email</td>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server" Width="316px"></asp:TextBox>
&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Generate OTP" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter OTP</td>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server" Width="326px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        <asp:Button ID="Button2" runat="server" Text="Verify OTP" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
