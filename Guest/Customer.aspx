<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Product.Guest.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <center>
    <br />
    <br />
        <h2>Customer Registration</h2>
        <br>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
    </div>
    <br />

    <div>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
    </div>
    <br />

    <div>
        <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
               </asp:RadioButtonList>
    </div>
    <br />
    
    <div>
        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="address" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label5" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
    </div>
    <br />

    <div>
        <asp:Label ID="Label6" runat="server"  Text="Password"></asp:Label>
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
    </div>
    <br />

    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
        </center>
</asp:Content>
