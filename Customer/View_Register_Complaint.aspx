<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="View_Register_Complaint.aspx.cs" Inherits="Product.Customer.View_Register_Complaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <br />
    <br />

    <center>
        <table>
            <tr>
                <th>Select Product</th>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList>

                </td>
            </tr>
            <tr>
                <th>Complaint</th>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                </th>
            </tr>
        </table>
        
    </center>
</asp:Content>
