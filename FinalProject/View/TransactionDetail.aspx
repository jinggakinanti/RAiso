<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="FinalProject.View.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Detail</h1>
    <div>
        <asp:GridView ID="GView_Detail" runat="server" AutoGenerateColumns="false" OnRowDataBound="GView_Detail_RowDataBound">
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
            </Columns>  
        </asp:GridView>
    </div>
</asp:Content>
