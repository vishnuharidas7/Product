<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Product_Registration.aspx.cs" Inherits="Product.Admin.Product_Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
     <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <center>
   
    <h1>Product Registration</h1>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Product"></asp:Label>
        <asp:TextBox ID="product" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
    </div>
         </center>
</asp:Content>
