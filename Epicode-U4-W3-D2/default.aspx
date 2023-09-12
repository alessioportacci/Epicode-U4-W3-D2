<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Epicode_U4_W3_D2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!-- Login -->
            <p>Inserisci username</p>
            <asp:TextBox ID="User" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="UserValidator" ControlToValidate="User" runat="server" 
                ErrorMessage="Inserire un username"></asp:RequiredFieldValidator>
            
            <p>Inserisci password</p>
            <input id="Pass" type="password" runat="server"/>
            <asp:RequiredFieldValidator ID="PassValidator" ControlToValidate="Pass" runat="server" 
                ErrorMessage="Inserire una password"></asp:RequiredFieldValidator>

            <br />
            <asp:Button ID="Login" runat="server" Text="Button" OnClick="Login_Click" />

        </div>
        
    </form>
</body>
</html>
