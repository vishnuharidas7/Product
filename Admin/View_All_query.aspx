<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="View_All_query.aspx.cs" Inherits="Product.Admin.View_All_query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <br />
    <br>
    <center>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
               <asp:TemplateField HeaderText="Serial No.">
                    <ItemTemplate>
                        <%# Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="p_name" HeaderText="Product" />
                <asp:BoundField DataField="query" HeaderText="Query" />
                <asp:BoundField DataField="name" HeaderText="User" />
                <asp:BoundField DataField="reply" HeaderText="Reply" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Reply_query.aspx?Id={0}" HeaderText="Reply" Text="Reply" />
            </Columns>

        </asp:GridView>
    </center>

</asp:Content>
