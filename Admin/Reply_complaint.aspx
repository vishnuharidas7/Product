<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Reply_complaint.aspx.cs" Inherits="Product.Admin.Reply_complaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <center>
        <h1>Update Complaint Status</h1>
        <table>
            <tr>
                <th>Product</th>
                <td> <asp:TextBox ID="txtproduct" runat="server" ReadOnly="true" Width="222px"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Complaint</th>
                <td>
                    <asp:TextBox ID="txtcomplaint" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                </td>

                <td>
                    &nbsp;</td>
            </tr>

            <tr>
                <th>Reply</th>
                <td>
                    <asp:TextBox ID="txtreply" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
        </table>

        <div>
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        </div>

    </center>
</asp:Content>
