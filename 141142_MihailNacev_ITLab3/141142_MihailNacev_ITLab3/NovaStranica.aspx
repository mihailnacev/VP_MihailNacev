<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovaStranica.aspx.cs" Inherits="_141142_MihailNacev_ITLab3.NovaStranica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 155px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
      
    
       
    
        <table align="center" class="auto-style1">
            <tr>
                <td>
            <asp:Panel ID="pnlPanela" runat="server" BackColor="Orange" Height="185px" style="margin-top: 0px">
            <asp:TextBox ID="txtOperand1" runat="server" EnableViewState="False"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txtOperand2" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRezultat" runat="server" Text="Label" EnableViewState="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOdzemi" runat="server" OnClick="btnOdzemi_Click" Text="Button" />
            <br />
        </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chbVidlivo" runat="server" AutoPostBack="True" OnCheckedChanged="chbVidlivo_CheckedChanged" Text="Видливо" />
                </td>
            </tr>
        </table>
    
       
      
    
       
    
    </div>
    </form>
</body>
</html>

