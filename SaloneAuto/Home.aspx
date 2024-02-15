<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SaloneAuto.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Preventivo Personalizzato</title>
    <style>
        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: palegreen;
        }
        .form-group {
            margin-bottom: 20px;
        }
        #imgAuto{
            max-height: 400px;
            max-width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Preventivo Personalizzato</h2>
            <div class="form-group">
                <label for="ddlAuto">Seleziona un'auto:</label>
                <asp:DropDownList ID="ddlAuto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAuto_SelectedIndexChanged"></asp:DropDownList>
                <br />
                <asp:Image ID="imgAuto" runat="server" />
            </div>
            <div class="form-group">
                <label for="chkOptional">Optional:</label><br />
                <asp:CheckBox ID="chkOptional1" runat="server" Text="Cerchi cromati" /><br />
                <asp:CheckBox ID="chkOptional2" runat="server" Text="Sedili riscaldati" /><br />
                <asp:CheckBox ID="chkOptional3" runat="server" Text="Aria condizionata" /><br />
            </div>
            <div class="form-group">
                <label for="ddlGaranzia">Anni di garanzia:</label>
                <asp:DropDownList ID="ddlGaranzia" runat="server">
                    <asp:ListItem Text="1 anno" Value="1" />
                    <asp:ListItem Text="2 anni" Value="2" />
                    <asp:ListItem Text="3 anni" Value="3" />
                </asp:DropDownList>
            </div>
            <asp:Button ID="btnStampa" runat="server" Text="Stampa Preventivo" OnClick="btnStampa_Click" />
            <hr />
            <div>
                <strong>Prezzo di base:</strong> <span id="lblPrezzoBase" runat="server"></span><br />
                <strong>Totale degli optional:</strong> <span id="lblTotaleOptional" runat="server"></span><br />
                <strong>Totale della garanzia:</strong> <span id="lblTotaleGaranzia" runat="server"></span><br />
                <strong>Totale complessivo:</strong> <span id="lblTotaleComplessivo" runat="server"></span><br />
            </div>
        </div>
    </form>
</body>
</html>
