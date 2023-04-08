<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebAppW9Homework.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Login Page</title>
    <link href="HomeStyle.css" rel="stylesheet" />
</head>
<body background="aaa.jpg">
   <form id="Loginform" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="UserName" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td colspan="2">
                         <asp:CheckBox ID="remember" runat="server" Text="Remember Me" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"> 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButton1" runat="server"></asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="btnSubmit_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Go to the sign-up page." OnClick="Button1_Click" CausesValidation = "false" />
                    </td>
                </tr>
            </table>
        </div>
        
       <asp:Label ID="Label" runat="server" Text="" BackColor="Transparent" ForeColor="Purple" Font-Italic="True" Font-Size="Large" Font-Underline="True"></asp:Label>
    </form>
</body>
</html>

