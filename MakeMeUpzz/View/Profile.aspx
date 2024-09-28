<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="MakeMeUpzz.View.Profile" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnReturn" runat="server" Text="Return" />
        </div>
        <div>
            <h2>Account Information</h2>
            <h4>Username</h4>
            <asp:Label ID="lblName" runat="server" Text="[Name]"></asp:Label>
            <h4>Email</h4>
            <asp:Label ID="lblEmail" runat="server" Text="[Email]"></asp:Label>
            <h4>Gender</h4>
            <asp:Label ID="lblGender" runat="server" Text="[Gender]"></asp:Label>
            <h4>Date of Birth</h4>
            <asp:Label ID="lblDOB" runat="server" Text="[DOB]"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnProfile" runat="server" Text="Update Profile" />
            <asp:Button ID="btnPassword" runat="server" Text="Update Password" />
        </div>
    </form>
</body>
</html>
