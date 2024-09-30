<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="FinalProject.View.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <div>
        <asp:GridView ID="GView_Cart" runat="server" AutoGenerateColumns="false" OnRowUpdating="GView_Cart_RowUpdating" OnRowDeleting="GView_Cart_RowDeleting" OnRowDataBound="GView_Cart_RowDataBound">
            <Columns>
                <asp:BoundField DataField="StationeryID" HeaderText="StationeryID" SortExpression="StationeryID"></asp:BoundField>
                <asp:TemplateField HeaderText="StationeryName">
                <ItemTemplate>
                    <asp:Label ID="Lbl_Name" runat="server" Text="Label"></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="StationeryPrice">
                <ItemTemplate>
                    <asp:Label ID="Lbl_Price" runat="server" Text="Label"></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                 <asp:TemplateField HeaderText="Actions">
                 <ItemTemplate>
                     <asp:Button ID="Btn_Update" runat="server" Text="Update" UseSubmitBehavior="false" CommandName="Update" />
                     <asp:Button ID="Btn_Delete" runat="server" Text="Remove" UseSubmitBehavior="false" CommandName="Delete" />
                 </ItemTemplate>
             </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="Btn_Checkout" runat="server" Text="Checkout" OnClick="Btn_Checkout_Click" />
    </div>
</asp:Content>
