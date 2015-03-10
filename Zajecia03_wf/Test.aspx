<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Zajecia03_wf.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ErrorMessage="RequiredFieldValidator" Text="!" ControlToValidate="txtFirstName">         
        </asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
        <div>
            <asp:TextBox ID="Imie" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                runat="server" 
                ErrorMessage="RequiredFieldValidator" Text="Uzupelnij pole Imie" ControlToValidate="Imie">
            </asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:TextBox ID="Nazwisko" 
                runat="server"></asp:TextBox><asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="RequiredFieldValidator" 
                    Text="Uzupełnij pole Nazwisko" ControlToValidate="Nazwisko"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:TextBox ID="Email" 
                runat="server"></asp:TextBox><asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="RequiredFieldValidator" 
                    Text="Uzupełnij pole Adres e-mail" ControlToValidate="Email"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:TextBox ID="ImieWspolautora" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                runat="server" ErrorMessage="RequiredFieldValidator" Text="Uzupelnij pole Imie wspolautora" ControlToValidate="ImieWspolautora"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:TextBox ID="NazwiskoWspolautora" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" 
                runat="server" ErrorMessage="RequiredFieldValidator" Text="Uzupelnij pole Nazwisko Wspolautora" ControlToValidate="NazwiskoWspolautora"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:TextBox ID="ImieOpiekuna" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" 
                runat="server" ErrorMessage="RequiredFieldValidator" Text="Uzupelnij pole Imie Opiekuna" ControlToValidate="ImieOpiekuna"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:TextBox ID="NazwiskoOpiekuna" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ErrorMessage="RequiredFieldValidator" Text="Uzupelnij pole NazwiskoOpiekuna" ControlToValidate="NazwiskoOpiekuna"></asp:RequiredFieldValidator>
        </div>
        <div>

        </div>
    </form>
</body>
</html>
