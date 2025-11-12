<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio161.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 16-1 (Segunda Parte)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 40px; font-family: Arial;">
            <h2>Laboratorio 16-1 (Suma de Números)</h2>

            <asp:Label ID="Label1" runat="server" Text="Ingrese el primer número:"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label2" runat="server" Text="Ingrese el segundo número:"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Button1_Click" /><br /><br />

            <asp:Label ID="LabelResultado" runat="server" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>

