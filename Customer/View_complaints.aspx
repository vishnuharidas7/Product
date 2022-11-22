<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="View_complaints.aspx.cs" Inherits="Product.Customer.View_complaints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <center>
        <h1>My Complaints</h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id">
            <Columns>
               <asp:TemplateField HeaderText="Serial No.">
                    <ItemTemplate>
                        <%# Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
                <asp:BoundField DataField="p_name" HeaderText="Product" />
                <asp:BoundField DataField="complaint" HeaderText="Complaint" />
                 <asp:BoundField DataField="reply" HeaderText="Reply" />
                <asp:BoundField DataField="status" HeaderText="Complaint Status" />
            </Columns>

        </asp:GridView>



    </center>
</asp:Content>
