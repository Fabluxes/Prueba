<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplicationS2.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">








    <asp:Label ID="txtPostBack" runat="server" Text="PostBack"></asp:Label>
    <asp:Button ID="bPostBack" runat="server" OnClick="bPostBack_Click" Text="PostBack" />
    <asp:Label ID="Label1" runat="server" Text="Antes del PostBack"></asp:Label>
    <p>
        <asp:Label ID="idCache" runat="server" Text="Cache"></asp:Label>
        <asp:TextBox ID="TbCACHE" runat="server" OnTextChanged="TbCACHE_TextChanged"></asp:TextBox>
        <asp:Label ID="TXTMchacheee" runat="server" Text="No se hace EL CACHE"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TBvalidacion" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="ReqeridoCampo" runat="server" ControlToValidate="TBvalidacion" ErrorMessage="CampoRequerido" ToolTip="Validacion"></asp:RequiredFieldValidator>
    </p>








</asp:Content>
