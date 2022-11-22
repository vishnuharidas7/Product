<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="Customer_Login.aspx.cs" Inherits="Product.Guest.Customer_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <br />
    <br />
    <center>   
        <div>
          <label class="control-label col-sm-2" for="society">Username</label>
           <asp:TextBox ID="txtusername" class="form-control" runat="server"></asp:TextBox>
        </div>

    <br />

    <div>              
        <label class="control-label col-sm-2" for="pswd">Password</label>
        <asp:TextBox ID="txtpassword" class="form-control" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
      </div>
        <br />

    <div>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    </div>
        </center>

</asp:Content>
