<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 174px;
            height: 26px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 662px;
            height: 463px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
     <div>

         <table align="center" border="1" cellspacing="0" style="background-color: #FFCC66; font-family: Arial, Helvetica, sans-serif; color: #FF0000;" class="auto-style3">
             <tr>
                 <td style="width: 174px">&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td style="width: 174px">Name</td>
                 <td>
                     <asp:TextBox ID="TextBox1" runat="server" Width="321px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td style="width: 174px">Email</td>
                 <td>
                     <asp:TextBox ID="TextBox2" runat="server" Width="318px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td style="width: 174px">Password</td>
                 <td>
                     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style1">Gender</td>
                 <td class="auto-style2">
                     <asp:RadioButton ID="RadioButton1" runat="server" GroupName="g" Text="Male" />
                     &nbsp;
                 <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g" Text="Female" />
                 </td>
             </tr>
             <tr>
                 <td style="width: 174px">City</td>
                 <td>
                     <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                         <asp:ListItem>Himatnagar</asp:ListItem>
                         <asp:ListItem>Surat</asp:ListItem>
                         <asp:ListItem></asp:ListItem>
                         <asp:ListItem></asp:ListItem>
                     </asp:DropDownList>
                 </td>
             </tr>
             <tr>
                 <td style="width: 174px">Image</td>
                 <td>
                     <asp:FileUpload ID="FileUpload1" runat="server" />
                     <asp:HiddenField ID="HiddenField1" runat="server" />
                     &nbsp;<asp:Image ID="Image1" runat="server" Height="34px" Width="32px" />
                     <asp:HiddenField ID="HiddenField2" runat="server" />
                     <asp:HiddenField ID="HiddenField3" runat="server" />
                 </td>
             </tr>
             <tr>
                 <td style="width: 174px">&nbsp;</td>
                 <td>&nbsp;&nbsp;
                 <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
                     &nbsp;
                 <asp:Button ID="Button7" runat="server"  Text="ShowAll" />
                 </td>
             </tr>
             <tr>
                 <td colspan="2">Search<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                     &nbsp;<asp:Button ID="Button3" runat="server" Text="Search"  />
                     &nbsp;&nbsp;
                 <asp:Button ID="Button5" runat="server" Text="Delete" />
                     &nbsp;<asp:Button ID="Button4" runat="server" Text="Edit"  />
                     &nbsp;<asp:Button ID="Button6" runat="server" Text="Update"  />
                 </td>
             </tr>
             </form>
             </body>
</html>
