<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="FinalProject.View.Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Stationery Details</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Lbl" runat="server" Text="Input quantity to add to your cart"></asp:Label>
        <br />
        <asp:Label ID="Lbl_Quantity" runat="server" Text="Quantity: "></asp:Label>
        <asp:TextBox ID="TBox_Quantity" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Btn_Add" runat="server" Text="Add to Cart" OnClick="Btn_Add_Click" />
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
