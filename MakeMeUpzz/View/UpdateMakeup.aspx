<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="MakeMeUpzz.View.UpdateMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />
        </div>
        <div>
            <h1>Update Makeup</h1>
        </div>
        <div>
            <p>Name <asp:TextBox ID="tbName" runat="server"></asp:TextBox></p>
            <p>Price <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox></p>
            <p>Weight <asp:TextBox ID="tbWeight" runat="server"></asp:TextBox></p>
            <p>Type Id <asp:TextBox ID="tbType" runat="server"></asp:TextBox></p>
            <p>Brand Id  <asp:TextBox ID="tbBrand" runat="server"></asp:TextBox></p>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
