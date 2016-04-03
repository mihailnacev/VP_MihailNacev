<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logiranje.aspx.cs" Inherits="_141142_MihailNacev_ITLab3.Logiranje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtPoraka" runat="server" EnableViewState="False" OnTextChanged="txtPoraka_TextChanged" ReadOnly="True" TextMode="MultiLine" Width="175px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnProveri" runat="server" Font-Names="Times New Roman" OnClick="btnProveri_Click" Text="Провери" />
&nbsp;
        <asp:Button ID="btnPrvaStrana" runat="server" Enabled="False" Font-Names="Times New Roman" PostBackUrl="~/Default.aspx" Text="Прва Страна" />
    
    </div>
    </form>
</body>
</html>
