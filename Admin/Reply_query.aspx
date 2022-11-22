<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Reply_query.aspx.cs" Inherits="Product.Admin.Reply_query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <center>
        <h1>Reply Query</h1>
        <table>
            <tr>
                <th>Product</th>
               <td></td>
                <td>
                    <asp:TextBox ID="txtproduct" runat="server" ReadOnly="true" Width="222px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <th>Query</th>
                <td></td>

                <td>
                    <asp:TextBox ID="txtquery" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <th>Reply</th>
                <td></td>
                <td>
                    <asp:TextBox ID="reply" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th colspan="5">
                    <asp:Button ID="Button1" runat="server" Text="Reply" OnClick="Button1_Click"/></th>
            </tr>

           

        </table>

    </center>
</asp:Content>
