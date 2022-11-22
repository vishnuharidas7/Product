<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="View_All_complaints.aspx.cs" Inherits="Product.Admin.View_All_complaints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/1.css" />
    <center>
        <h1>User Complaints</h1>
    </center>
    <br />
    <br />

    <div>
        <asp:Button ID="Button1" runat="server" Text="Filter" OnClick="Button1_Click" />
    </div>
    <br />
    <div id="DateRange" runat="server">
    <b>Date Range</b>
    <br />
    <br />
    
        <table>
            <tr>
                <th>From Date</th>
            <td></td>
            <td>
                <asp:DropDownList ID="from_day" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="from_month" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="from_year" runat="server"></asp:DropDownList>
            </td>
            <td></td>
       
            <th>To Date</th>
            <td></td>
            <td>
                <asp:DropDownList ID="to_day" runat="server"></asp:DropDownList>
            </td>
            <td></td>
            <td>
                <asp:DropDownList ID="to_month" runat="server"></asp:DropDownList>
            </td>
            <td></td>
            <td>
                <asp:DropDownList ID="to_year" runat="server"></asp:DropDownList>
            </td>
            <td></td>
                  <th>
                      <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
                </th>
          </tr>
            
        </table>
        <br />
        <br />
   </div>
    <center>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id">
            <Columns>
                <asp:TemplateField HeaderText="Serial No.">
                    <ItemTemplate>
                        <%# Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
                <asp:BoundField DataField="name" HeaderText="User" />
                <asp:BoundField DataField="p_name" HeaderText="Product" />
                <asp:BoundField DataField="complaint" HeaderText="Complaint" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:HyperLinkField HeaderText="Update Status" Text="Update Status" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Reply_complaint.aspx?Id={0}" />
                
            </Columns>

        </asp:GridView>

    </center>
    
</asp:Content>
