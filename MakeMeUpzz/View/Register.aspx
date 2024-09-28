<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MakeMeUpzz.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register</h1>
                <table>
                    <tr>
                        <td><asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
                        <td><asp:TextBox ID="registerNameBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label2" runat="server" Text="Email"></asp:Label></td>
                        <td><asp:TextBox ID="registerEmailBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label3" runat="server" Text="Password"></asp:Label></td>
                        <td><asp:TextBox ID="registerPasswordBox" runat="server" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label></td>
                        <td><asp:TextBox ID="registerConfirmPasswordBox" runat="server" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label></td>
                        <td>
                            <asp:RadioButtonList ID="genderListRadioButton" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="Male">Male</asp:ListItem>
                                <asp:ListItem Value="Female">Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label6" runat="server" Text="Date of Birth"></asp:Label></td>
                        <td><asp:TextBox ID="tbDOB" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            Already have an account? 
                            <asp:HyperLink ID="loginHyperlinkButton" runat="server" NavigateUrl="~/View/Login.aspx">Login</asp:HyperLink>
                        </td>
                    </tr>
                     <tr>
                        <td colspan="2">
                            <asp:Label ID="errorMessage" runat="server" ForeColor="Red" Text="" Visible="true"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" />
                        </td>
                    </tr>
                </table>
        </div>
    </form>
</body>
</html>
