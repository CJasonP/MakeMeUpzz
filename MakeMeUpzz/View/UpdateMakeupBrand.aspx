<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeupBrand.aspx.cs" Inherits="MakeMeUpzz.View.UpdateMakeupBrand" %>

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
            <h1>Update Makeup Brand</h1>
        </div>
        <div>
            <p>Name <asp:TextBox ID="tbName" runat="server"></asp:TextBox></p>
            <p>Rating <asp:TextBox ID="tbRating" runat="server"></asp:TextBox></p>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
