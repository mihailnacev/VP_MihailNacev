<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prv_Del.aspx.cs" Inherits="_141142_MihailNacev_ITLab3.Prv_Del" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList ID="cblLista" runat="server"></asp:CheckBoxList>
        <br />
        <asp:Label ID="lblLabela" runat="server" Text="Броење на селектирани ставки"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnKopce" runat="server" Text="Копче" EnableTheming="False" OnClick="btnKopce_Click" />
    </div>
    </form>
</body>
</html>
