<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="_Prueba_Ajax1._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <script type="text/javascript" src="Scripts/callbackScript.js"></script>
</asp:Content>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:DropDownList ID="DropDownListChoice" runat="server" onchange="myServerCall(MainContent_DropDownListChoice.value)">
        <asp:ListItem>Choice 1</asp:ListItem>
        <asp:ListItem>Choice 2</asp:ListItem>
        <asp:ListItem>Choice 3</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
</asp:Content>
