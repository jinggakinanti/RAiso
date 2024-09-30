<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FinalProject.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile Update</h1>
     <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
     <div>
         <asp:Label ID="Lbl_DOB" runat="server" Text="Date of Birth: "></asp:Label>
         <asp:TextBox ID="TBox_DOB" runat="server"></asp:TextBox>
         <asp:Calendar ID="Calendar_DOB" runat="server" OnSelectionChanged="Calendar_DOB_SelectionChanged"></asp:Calendar>
    </div>
     <div>
         <asp:Label ID="Lbl_Gender" runat="server" Text="Gender: "></asp:Label>
         <asp:RadioButtonList ID="RBL_Gender" runat="server">
         <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
         <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
         </asp:RadioButtonList>
    </div>
     <div>
         <asp:Label ID="Lbl_Address" runat="server" Text="Address: "></asp:Label>
         <asp:TextBox ID="TBox_Address" runat="server"></asp:TextBox>
     </div>
     <div>
         <asp:Label ID="Lbl_Password" runat="server" Text="Password: "></asp:Label>
         <asp:TextBox ID="TBox_Password" runat="server"></asp:TextBox>
     </div>
     <div>
         <asp:Label ID="Lbl_Phone" runat="server" Text="Phone: "></asp:Label>
         <asp:TextBox ID="TBox_Phone" runat="server"></asp:TextBox>
     </div>
     <div>
         <asp:Button ID="Btn_Update" runat="server" Text="Update Profile" OnClick="Btn_Update_Click"/>
    
     </div>
     <div>
         <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
     </div>
</asp:Content>
