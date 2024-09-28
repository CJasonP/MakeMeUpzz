<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="MakeMeUpzz.View.ManageMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Makeup</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Manage Makeup</h1>
            <asp:Button ID="btnInsertMakeup" runat="server" Text="Insert Makeup" OnClick="btnInsertMakeup_Click" />
            <asp:Button ID="btnInsertMakeupType" runat="server" Text="Insert Makeup Type" OnClick="btnInsertMakeupType_Click" />
            <asp:Button ID="btnInsertMakeupBrand" runat="server" Text="Insert Makeup Brand" OnClick="btnInsertMakeupBrand_Click" />
            <h2>Makeup Items</h2>
            <asp:GridView ID="gvMakeup" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="MakeupID" HeaderText="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Weight" HeaderText="Weight (grams)" />
                    <asp:BoundField DataField="TypeName" HeaderText="Type" />
                    <asp:BoundField DataField="BrandName" HeaderText="Brand" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateMakeup" runat="server" Text="Update" CommandArgument='<%# Eval("MakeupID") %>' />
                            <asp:Button ID="btnDeleteMakeup" runat="server" Text="Delete" CommandArgument='<%# Eval("MakeupID") %>' OnClick="btnDeleteMakeup_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <h2>Makeup Types</h2>
            <asp:GridView ID="gvMakeupType" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="TypeID" HeaderText="ID" />
                    <asp:BoundField DataField="TypeName" HeaderText="Type Name" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateMakeupType" runat="server" Text="Update" CommandArgument='<%# Eval("TypeID") %>' />
                            <asp:Button ID="btnDeleteMakeupType" runat="server" Text="Delete" CommandArgument='<%# Eval("TypeID") %>' OnClick="btnDeleteMakeupType_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <h2>Makeup Brands</h2>
            <asp:GridView ID="gvMakeupBrand" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="BrandID" HeaderText="ID" />
                    <asp:BoundField DataField="BrandName" HeaderText="Brand Name" />
                    <asp:BoundField DataField="Rating" HeaderText="Rating" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateMakeupBrand" runat="server" Text="Update" CommandArgument='<%# Eval("BrandID") %>'/>
                            <asp:Button ID="btnDeleteMakeupBrand" runat="server" Text="Delete" CommandArgument='<%# Eval("BrandID") %>' OnClick="btnDeleteMakeupBrand_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
