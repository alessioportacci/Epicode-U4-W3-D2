<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Epicode_U4_W3_D2.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <p>Inserisci Nome</p>
            <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="NomeValidator" ControlToValidate="Nome" runat="server" 
                ErrorMessage="Inserire un nome"></asp:RequiredFieldValidator>
            
            <p>Inserisci Cognome</p>
            <asp:TextBox ID="Cognome" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CognomeValidator" ControlToValidate="Cognome" runat="server" 
                ErrorMessage="Inserire un cognome"></asp:RequiredFieldValidator>


            <p>Seleziona Sala</p>
            <asp:DropDownList ID="DropDownSala" runat="server">
                <asp:ListItem Value="1" Text="Sala Nord"></asp:ListItem>
                <asp:ListItem Value="2" Text="Sala Est"></asp:ListItem>
                <asp:ListItem Value="3" Text="Sala Sud"></asp:ListItem>
            </asp:DropDownList>

            <p>Ridotto</p>
            <asp:CheckBox ID="Ridotto" runat="server" /> 

            <asp:Button ID="Aggiungi" runat="server" Text="Compra Biglietto" OnClick="Aggiungi_Click"/>


            <br />
            <br />
            <br />
            <br />
            <p id="Nord" runat="server"> </p>
            <p id="Est"  runat="server">  </p>
            <p id="Sud"  runat="server">  </p>
            <p id="Rido" runat="server"></p>



        </div>
    </form>
</body>
</html>
