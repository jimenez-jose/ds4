<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Laboratorio 15-4 - Suma de Números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px; font-family: Arial; font-size: 16px;">
            <h2>Laboratorio 15-4</h2>
            <p>Ingrese dos números y presione el botón para sumarlos:</p>

            <asp:Label ID="Label1" runat="server" Text="Número 1:"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label2" runat="server" Text="Número 2:"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Button1_Click" /><br /><br />

            <asp:Label ID="LabelResultado" runat="server" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
