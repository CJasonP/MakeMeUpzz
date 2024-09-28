<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="MakeMeUpzz.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Update Profile</h2>
        <div>
            <p>Username: <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox></p>
            <p>Email: <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox></p>
            <p>Gender: 
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Select Gender" Value="" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:DropDownList>
            </p>
            <p>Date of Birth: <asp:TextBox ID="tbDateOfBirth" runat="server"></asp:TextBox></p>

            <p>
                <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click" />
            </p>
            <asp:Label ID="lblProfileMessage" runat="server"/>
        </div>
        </div>
    </form>
</body>
</html>
