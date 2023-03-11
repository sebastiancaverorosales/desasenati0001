<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CALCULAR NOTAS<br />
            INGRESAR CURSO<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            INGRESAR NOTA 1<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            INGRESAR NOTA 2<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            INGRESAR NOTA 3<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            INGRESAR NOTA 4<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            PROMEDIO<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            CONDICIÓN<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="aceptar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="limpiar" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
