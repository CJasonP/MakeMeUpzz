<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="MakeMeUpzz.View.UpdatePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
                 <h2>Change Password</h2>
             </div>
             <div>
                 <p>Old Password: <asp:TextBox ID="tbOldPassword" runat="server" TextMode="Password"></asp:TextBox></p>
                 <p>New Password: <asp:TextBox ID="tbNewPassword" runat="server" TextMode="Password"></asp:TextBox></p>
             <div>
                 <asp:Button ID="btnUpdatePassword" runat="server" Text="Update Password" OnClick="btnUpdatePassword_Click" />
             </div>
                 <asp:Label ID="lblPasswordMessage" runat="server"/>
             </div>
        </div>
    </form>
</body>
</html>
