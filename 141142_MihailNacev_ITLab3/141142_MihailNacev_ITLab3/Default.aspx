<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_141142_MihailNacev_ITLab3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblTime" runat="server" Text="Моментално време" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="Navy"></asp:Label>

    </div>
        <p>
        <asp:Label ID="lblTimeNow" runat="server" Text="TimeNow" Font-Names="Times New Roman" ForeColor="Navy" Font-Size="Medium"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnTIme" runat="server" Text="Button" OnClick="btnTIme_Click" />

        </p>
    </form>
</body>
</html>
