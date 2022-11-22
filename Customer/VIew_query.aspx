<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="VIew_query.aspx.cs" Inherits="Product.Customer.VIew_query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
        <center>
            <h1>My Complaints</h1>
             <asp:GridView ID="GridView1" runat="server" ForeColor="#333333" AutoGenerateColumns="False" DataKeyNames="Id">
            <Columns>
                <asp:TemplateField HeaderText="Serial No.">
                    <ItemTemplate>
                        <%# Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="p_name" HeaderText="Product" />
                <asp:BoundField DataField="query" HeaderText="Query" />
                <asp:BoundField DataField="reply" HeaderText="Query Reply" />
            </Columns>

        </asp:GridView>





        </center>
</asp:Content>
