<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <asp:Label ID="lbl_add" runat="server"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="labl_sub" runat="server"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="lbl_mul" runat="server"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="lbl_div" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
