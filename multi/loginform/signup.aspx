﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 94%;
            height: 357px;
            border: 1px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style3 {
            width: 246px;
            text-align: center;
            height: 68px;
        }
        .auto-style4 {
            color: #FFFFFF;
            margin-left: 142px;
            margin-top: 24px;
            background-color: #006699;
        }
        .auto-style5 {
            height: 52px;
            text-align: center;
            font-size: large;
        }
        .auto-style11 {
            height: 106px;
        }
        .auto-style12 {
            color: #FFFFFF;
            margin-left: 28px;
            background-color: #006699;
        }
        .auto-style13 {
            width: 246px;
            height: 67px;
            text-align: center;
        }
        .auto-style14 {
            text-align: center;
            width: 495px;
            height: 68px;
        }
        .auto-style15 {
            text-align: center;
            width: 495px;
            height: 67px;
        }
    </style>
</head>
<body style="width: 772px; height: 456px; margin-left: 380px; margin-top: 74px;">
    <form id="form1" runat="server">
        <div>
            <table align="center" border="0" class="auto-style1" Style="border-radius: 12px;">
                <tr>
                    <td class="auto-style5" colspan="2"><strong>SIGN UP</strong></td>
                </tr>
                <tr>
                    <td class="auto-style13">ENTER YOUR NAME </td>
                    <td class="auto-style15">
                        <asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="365px" Style="border-radius: 12px;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">EMAIL</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="TextBox2" runat="server" Height="38px" Width="365px" Style="border-radius: 12px;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">PASSWORD</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="TextBox3" runat="server" Height="38px" Width="365px" Style="border-radius: 12px;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" Height="52px" Text="SIGN UP" Width="154px" Style="border-radius: 12px;" OnClick="Button1_Click1"/>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">Already Have An Account ?
                        <a href="login.aspx">Log in</a>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
