<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home Page</h1>
    <div>
        <h3>Stationery List</h3>
    </div>
    <div>
        <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click" />
    </div>
    <br />
    <div>
        <asp:GridView ID="GView_Stat" runat="server" AutoGenerateColumns="false" OnRowDeleting="GView_Stat_RowDeleting" OnRowUpdating="GView_Stat_RowUpdating" OnSelectedIndexChanged="GView_Stat_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="StationeryId" HeaderText="StationeryId" SortExpression="StationeryId"></asp:BoundField>
                <asp:BoundField DataField="StationeryName" HeaderText="StationeryName" SortExpression="StationeryName"></asp:BoundField>
                <asp:BoundField DataField="StationeryPrice" HeaderText="StationeryPrice" SortExpression="StationeryPrice"></asp:BoundField>
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="Btn_Select" runat="server" Text="Select" UseSubmitBehavior="false" CommandName="Select"/>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Actions">
                 <ItemTemplate>
                     <asp:Button ID="Btn_Delete" runat="server" Text="Delete" UseSubmitBehavior="false" CommandName="Delete" />
                     <asp:Button ID="Btn_Update" runat="server" Text="Update" UseSubmitBehavior="false" CommandName="Update" />
                 </ItemTemplate>
             </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
    </div>
</asp:Content>
