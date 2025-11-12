<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio161._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 16-1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Laboratorio 16-1</h2>
            <asp:Label ID="Label1" runat="server" Text="Introduzca un texto:"></asp:Label><br /><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnMensaje" runat="server" Text="Mostrar Mensaje" OnClick="btnMensaje_Click" />
        </div>
    </form>
</body>
</html>
