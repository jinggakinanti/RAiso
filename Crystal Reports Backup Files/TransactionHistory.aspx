<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="FinalProject.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction History</h1>
    <div>
        <asp:GridView ID="GView_Transaction" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="GView_Transaction_SelectedIndexChanged" OnRowDataBound="GView_Transaction_RowDataBound">
            <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>            
            <asp:TemplateField HeaderText="UserName">
            <ItemTemplate>
                <asp:Label ID="Lbl_Name" runat="server" Text="Label"></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Actions">
             <ItemTemplate>
                 <asp:Button ID="Btn_Select" runat="server" Text="Select" UseSubmitBehavior="false" CommandName="Select" />
             </ItemTemplate>
         </asp:TemplateField>
        </Columns>
        </asp:GridView>
    </div>
</asp:Content>
