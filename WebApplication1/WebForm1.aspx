<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visualizza Candidato</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnMostraCandidato" runat="server" OnClick="btnMostraCandidato_Click" Text="Mostra Candidato" />

            <asp:Label ID="lblCandidato" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
