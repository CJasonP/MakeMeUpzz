<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeupTypex.aspx.cs" Inherits="MakeMeUpzz.View.UpdateMakeupTypex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnReturn" runat="server" Text="Return" />
        </div>
        <div>
            <h1>Update Makeup Type</h1>
        </div>
        <div>
            <p>Name <asp:TextBox ID="tbName" runat="server"></asp:TextBox></p>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
