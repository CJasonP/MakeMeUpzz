<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="MakeMeUpzz.View.OrderMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Makeup</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Order Makeup</h2>
            <asp:GridView ID="gvMakeup" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvMakeup_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="MakeupName" HeaderText="Makeup Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Weight" HeaderText="Weight(g)" />
                    <asp:BoundField DataField="TypeName" HeaderText="Type" />
                    <asp:BoundField DataField="BrandName" HeaderText="Brand" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:TextBox ID="tbQuantity" runat="server" Text="1" Width="50px" />
                            <asp:Button ID="btnOrder" runat="server" Text="Order" CommandArgument='<%# Eval("MakeupID") %>' OnClick="btnOrder_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnClearCart" runat="server" Text="Clear Cart" OnClick="btnClearCart_Click" />
            <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
