<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio153.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Saludo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px; font-family: Arial; font-size: 16px;">
            <asp:Label ID="Label1" runat="server" Text="Introduzca un Texto"></asp:Label><br /><br />
            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Enviar Saludo!" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>


