<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Trainfind.aspx.cs" Inherits="ESE_PROJECT.Trainfindaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #GridView1{
            border:3px solid black;
        }
            
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="True" EmptyDataText="No Flights found" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="white" BorderColor="Black" />
            <EditRowStyle BackColor="#2461BF" BorderColor="Black" />
            <EmptyDataRowStyle BackColor="Black" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" BorderColor="Black" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text=" "></asp:Label>
    </p>
        <p>
            <asp:Button ID="Button2" runat="server" BackColor="#66CCFF" ForeColor="White" Text="Book Now" OnClick="Button2_Click" style="border: 3px solid black; border-radius: 4px; padding:4px;" />
    </p>
        <p>
            &nbsp;</p>
    </center>
</asp:Content>
