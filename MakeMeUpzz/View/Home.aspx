<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MakeMeUpzz.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <asp:Panel ID="pnlCustomerNav" runat="server" Visible="false">
                    <asp:Button ID="btnOrderMakeup" runat="server" Text="Order Makeup" OnClick="btnOrderMakeup_Click" />
                    <asp:Button ID="btnHistory" runat="server" Text="History" OnClick="btnHistory_Click" />
                    <asp:Button ID="btnProfile" runat="server" Text="Profile" OnClick="btnProfile_Click" />
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
                </asp:Panel>
                <asp:Panel ID="pnlAdminNav" runat="server" Visible="false">
                    <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
                    <asp:Button ID="btnManageMakeup" runat="server" Text="Manage Makeup" OnClick="btnManageMakeup_Click" />
                    <asp:Button ID="btnOrderQueue" runat="server" Text="Order Queue" OnClick="btnOrderQueue_Click" />
                    <asp:Button ID="btnProfileAdmin" runat="server" Text="Profile" OnClick="btnProfileAdmin_Click" style="height: 29px" />
                    <asp:Button ID="btnTransactionReport" runat="server" Text="Transaction Report" OnClick="btnTransactionReport_Click" />
                    <asp:Button ID="btnLogoutAdmin" runat="server" Text="Logout" OnClick="btnLogout_Click" />
                </asp:Panel>
            </nav>
            <h1>Welcome to MakeMeUp</h1>
            <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" Visible="false">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="User ID" />
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth" DataFormatString="{0:yyyy-MM-dd}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
