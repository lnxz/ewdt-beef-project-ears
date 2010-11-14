﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/LoggedInStudent.Master" AutoEventWireup="true" CodeBehind="HomeStu.aspx.cs" Inherits="earsBEEF.HomeStu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .style5
        {
            width: 72px;
        }
        .style6
        {
            width: 174px;
        }
        .style14
        {
            width: 82px;
        }
        .style15
        {
            width: 151px;
        }
        .style17
        {
            width: 123px;
        }
        .style18
        {
            width: 322px;
        }
        .style20
        {
            width: 373px;
        }
        .style22
        {
            font-weight: 700;
        }
        .style23
        {
            font-weight: 700;
        }
        .style24
        {
            font-weight: 700;
        }
        .style28
        {
            width: 149px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="725px" Width="853px">
        <br />
        <br />
<asp:Panel ID="Panel2" runat="server" BackColor="#FF6666" ForeColor="#CCCC00">
            <asp:Label ID="Label4" runat="server" CssClass="style22" Text="Announcements"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="style5">
                        Nov 11</td>
                    <td class="style6">
                        Yeak Shaw Wen</td>
                    <td>
                        <asp:HyperLink ID="HyperLink4" runat="server">EWDT Project submission due in 4 weeks </asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Nov 15</td>
                    <td class="style6">
                        Shaun</td>
                    <td>
                        &nbsp;<asp:HyperLink ID="HyperLink5" runat="server">Sign up for TP Cyber Games 2010 !</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        Nov 16</td>
                    <td class="style6">
                        Nicholas Shen</td>
                    <td>
                        <asp:HyperLink ID="HyperLink6" runat="server">C219 Booth for CCN day  ! Cookies for $2</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
<asp:Panel ID="Panel3" runat="server" BackColor="#FFFF99">
            <asp:Label ID="Label1" runat="server" CssClass="style23" Text="Upcoming Events"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="style14">
                        Event Date</td>
                    <td class="style15">
                        Registration Ends</td>
                    <td class="style18">
                        Name</td>
                    <td class="style17">
                        Category</td>
                    <td>
                        Organizer</td>
                </tr>
                <tr>
                    <td class="style14">
                        Nov 18</td>
                    <td class="style15">
                        Nov 16</td>
                    <td class="style18">
                        TPRawks</td>
                    <td class="style17">
                        Campus-Wide</td>
                    <td>
                        Pua Yeow Cheong</td>
                </tr>
                <tr>
                    <td class="style14">
                        Nov 19</td>
                    <td class="style15">
                        Nov 19</td>
                    <td class="style18">
                        CCN Day</td>
                    <td class="style17">
                        Campus-Wide</td>
                    <td>
                        Yeak Shaw Wen</td>
                </tr>
                <tr>
                    <td class="style14">
                        Dec 27</td>
                    <td class="style15">
                        Nov 30</td>
                    <td class="style18">
                        Orientation Training Camp</td>
                    <td class="style17">
                        Leadership</td>
                    <td>
                        TPSU</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel4" runat="server" BackColor="#66FF66">
            <asp:Label ID="Label3" runat="server" CssClass="style24" 
                Text="Registered Events"></asp:Label>
            <br />
            <table style="width: 100%;">
                <tr>
                    <td class="style28">
                        Event Starting Date</td>
                    <td class="style20">
                        Name</td>
                </tr>
                <tr>
                    <td class="style28">
                        Dec 27</td>
                    <td class="style20">
                        Orientation Training Camp</td>
                </tr>
                <tr>
                    <td class="style28">
                        Dec 30</td>
                    <td class="style20">
                        Run for Hope helpers</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>
</asp:Content>
