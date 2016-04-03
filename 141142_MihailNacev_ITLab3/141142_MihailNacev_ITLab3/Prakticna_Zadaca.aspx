<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prakticna_Zadaca.aspx.cs" Inherits="_141142_MihailNacev_ITLab3.Prakticna_Zadaca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 37%;
        }
        .auto-style2 {
            height: 23px;
            width: 367px;
        }
        .auto-style3 {
            width: 71px;
        }
        .auto-style4 {
            height: 23px;
            width: 71px;
        }
        .auto-style9 {
            width: 71px;
            height: 44px;
        }
        .auto-style10 {
            height: 44px;
            width: 367px;
        }
        .auto-style13 {
            width: 367px;
        }
        .auto-style14 {
            width: 71px;
            height: 58px;
        }
        .auto-style15 {
            width: 367px;
            height: 58px;
        }
        .auto-style16 {
            width: 71px;
            height: 73px;
        }
        .auto-style17 {
            height: 73px;
            width: 367px;
        }
        .auto-style18 {
            width: 71px;
            height: 51px;
        }
        .auto-style19 {
            width: 367px;
            height: 51px;
        }
        .auto-style20 {
            width: 478px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Име"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtIme" runat="server" Width="206px"></asp:TextBox>
                </td>
                <td rowspan="11" class="auto-style20">
                    <asp:Panel ID="pnlPanela" runat="server" Height="514px" BackColor="#FFCC00" ForeColor="Navy" Visible="False">
                        Почитуван патнику<br />
                        <asp:Label ID="lblPatnik" runat="server" Font-Names="Times New Roman" ForeColor="#CC0000" Text="Label"></asp:Label>
                        <br />
                        Издадена ви е карта за<br />
                        <asp:Label ID="lblSredstvo" runat="server" Font-Bold="True" Font-Italic="True" Text="Label"></asp:Label>
                        <br />
                        со почетна дестинација<br />
                        <asp:Label ID="lblOd" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                        <br />
                        и крајна дестинација<br />
                        <asp:Label ID="lblDo" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                        <br />
                        Времето на поаѓање е<br />
                        <asp:Label ID="lblVreme" runat="server" Font-Bold="True" Font-Italic="True" Text="Label"></asp:Label>
                        <br />
                        <br />
                        Вашето место на седење ќе биде во зоната<br /> за
                        <asp:Label ID="lblZona" runat="server" Font-Bold="True" Font-Italic="True" Text="Label"></asp:Label>
                        &nbsp;во
                        <asp:Label ID="lblKlasa" runat="server" Font-Bold="True" Font-Italic="True" Text="Label"></asp:Label>
                        &nbsp;класа<br /> и во текот на патувањето ќе бидете послужени<br /> со
                        <asp:Label ID="lblPosluga" runat="server" Font-Bold="True" Font-Italic="True" Text="Label"></asp:Label>
                        <br />
                        <asp:Image ID="imgSlika" runat="server" Height="165px" style="margin-left: 0px" Width="355px" />
                        <br />
                        Ви благодариме на довербата и ви
                        <br />
                        посакуваме среќен пат!</asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Презиме"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPrezime" runat="server" Width="204px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Од"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlOd" runat="server" Width="109px">
                        <asp:ListItem>Скопје</asp:ListItem>
                        <asp:ListItem>Тетово</asp:ListItem>
                        <asp:ListItem>Куманово</asp:ListItem>
                        <asp:ListItem>Штип</asp:ListItem>
                        <asp:ListItem>Велес</asp:ListItem>
                        <asp:ListItem>Битола</asp:ListItem>
                        <asp:ListItem>Охрид</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Text="До"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlDo" runat="server" Height="17px" Width="107px">
                        <asp:ListItem>Скопје</asp:ListItem>
                        <asp:ListItem>Тетово</asp:ListItem>
                        <asp:ListItem>Куманово</asp:ListItem>
                        <asp:ListItem>Штип</asp:ListItem>
                        <asp:ListItem>Велес</asp:ListItem>
                        <asp:ListItem>Битола</asp:ListItem>
                        <asp:ListItem>Охрид</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Датум на тргање"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlDen" runat="server">
                    </asp:DropDownList>
&nbsp;<asp:DropDownList ID="ddlMesec" runat="server">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:DropDownList ID="ddlGodina" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Text="Време на тргање"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlVreme" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label7" runat="server" Text="Превозно средство"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:ListBox ID="lstSredstvo" runat="server" Height="41px">
                        <asp:ListItem Value="Images\airplane.jpg">авион</asp:ListItem>
                        <asp:ListItem Value="Images\train.jpg">воз</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="Label8" runat="server" Text="Зона"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:RadioButtonList ID="rblZona" runat="server">
                        <asp:ListItem>Пушачи</asp:ListItem>
                        <asp:ListItem>Непушачи</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="Label9" runat="server" Text="Класа"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:RadioButtonList ID="rblKlasa" runat="server" Height="73px" style="margin-bottom: 0px" Width="225px" RepeatDirection="Horizontal">
                        <asp:ListItem>Економска</asp:ListItem>
                        <asp:ListItem>Бизнис</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label10" runat="server" Text="Послуга"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:CheckBoxList ID="cblPosluga" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Пијалок</asp:ListItem>
                        <asp:ListItem>Кафе</asp:ListItem>
                        <asp:ListItem>Оброк</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">
                    <asp:Button ID="btnPodnesi" runat="server" Text="Поднеси" OnClick="btnPodnesi_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
