<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarAlumno.aspx.cs" Inherits="WebApplicationS2.BuscarAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCarnet" runat="server" OnTextChanged="txtCarnet_TextChanged">Carnet</asp:TextBox>
            <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="txtNombre_TextChanged">Nombre</asp:TextBox>
            <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" OnClick="btn_Buscar_Click" />
           
            
            <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" OnClick="btn_Guardar_Click" />

        </div>
    </form>
</body>
</html>
