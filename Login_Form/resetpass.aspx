<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resetpass.aspx.cs" Inherits="resetpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 67%;
            background-color: #FFCC66;
        }
        .auto-style2 {
            height: 26px;
            text-align: center;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            width: 333px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">Reset Password</td>
                </tr>
                <tr>
                    <td class="auto-style5">New Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server" Width="332px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Confirm Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server" Width="332px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click" style="height: 29px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
