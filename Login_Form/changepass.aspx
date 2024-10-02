<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changepass.aspx.cs" Inherits="changepass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 73%;
            background-color: #FF9966;
        }
        .auto-style3 {
            height: 56px;
            text-align: center;
        }
        .auto-style4 {
            width: 341px;
            height: 55px;
            text-align: center;
        }
        .auto-style5 {
            height: 55px;
            text-align: center;
        }
        .auto-style6 {
            width: 341px;
            height: 71px;
            text-align: center;
        }
        .auto-style7 {
            height: 71px;
            text-align: center;
        }
        .auto-style8 {
            width: 341px;
            height: 66px;
            text-align: center;
        }
        .auto-style9 {
            height: 66px;
            text-align: center;
        }
        .auto-style10 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2">Change Password</td>
                </tr>
                <tr>
                    <td class="auto-style4">Old Password</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="230px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">New Password</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox2" runat="server" Height="40px" Width="230px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Confirm Password</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox3" runat="server" Height="46px" Width="230px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10" colspan="2">
                        <asp:Button ID="Button2" runat="server" Height="38px" Text="Save" Width="85px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" Height="38px" PostBackUrl="~/homepage.aspx" Text="Cancle" Width="85px" />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
