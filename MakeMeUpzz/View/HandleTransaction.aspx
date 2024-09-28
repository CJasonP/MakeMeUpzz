<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HandleTransaction.aspx.cs" Inherits="MakeMeUpzz.View.HandleTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Handle Transactions</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Handle Transactions</h2>
            <asp:GridView ID="gvTransactions" runat="server" AutoGenerateColumns="false" OnRowDataBound="gvTransactions_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd}" />
                    <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnHandle" runat="server" Text="Handle Transaction" CommandArgument='<%# Eval("TransactionID") %>' OnClick="btnHandle_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
