<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="FinalProject.View.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Stationery</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click" />
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
