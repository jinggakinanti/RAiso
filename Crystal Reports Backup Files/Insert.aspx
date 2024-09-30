<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="FinalProject.View.Insert1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Insert Stationery</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click" />
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
