﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalProject.View.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login Page</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Password" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="TBox_Password" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="CBox_Remember" runat="server" />
        <asp:Label ID="Lbl_Remember" runat="server" Text="Remember Me"></asp:Label>
    </div>
    <div>
        <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click" />
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
