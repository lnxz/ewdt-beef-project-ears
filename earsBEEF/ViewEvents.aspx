﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/LoggedOut.Master" AutoEventWireup="true" CodeBehind="ViewEvents.aspx.cs" Inherits="earsBEEF.ViewEvents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="12pt" 
            Text="View All Events"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" 
            Text="There are currently no events open for registration" Visible="False" 
            Font-Bold="True" Font-Size="8pt"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="EventView" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Height="185px" 
            Width="88%" DataKeyNames="EventID"
        onselectedindexchanging="GridView1_SelectedIndexChanging">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" 
                ReadOnly="True" />
            <asp:BoundField DataField="Venue" HeaderText="Venue" SortExpression="Venue" 
                ReadOnly="True" />
            <asp:BoundField DataField="RegistrationCost" HeaderText="RegistrationCost" 
                SortExpression="RegistrationCost" ReadOnly="True" />
            <asp:BoundField DataField="EventDate" HeaderText="EventDate" 
                SortExpression="EventDate" ReadOnly="True">
            <ControlStyle Width="200px" />
            <HeaderStyle Width="200px" />
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField DataField="RegistrationStart" HeaderText="RegistrationStart" 
                SortExpression="RegistrationStart" ReadOnly="True" 
                DataFormatString="{0:MM/dd/yyyy}" >
            <ControlStyle Width="170px" />
            </asp:BoundField>
            <asp:BoundField DataField="RegistrationEnd" HeaderText="RegistrationEnd" 
                SortExpression="RegistrationEnd" ReadOnly="True" 
                DataFormatString="{0:MM/dd/yyyy}"></asp:BoundField>
            <asp:CommandField ButtonType="Button" SelectText="Register" 
                ShowSelectButton="True" CancelText="" DeleteText="" EditText="" 
                InsertText="" NewText=""/>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
    </asp:Content>
