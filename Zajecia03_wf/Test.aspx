<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Zajecia03_wf.Test" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formularz zgłoszeniowy</title>
    <link rel="stylesheet" href="Content/Site.css" type="text/css" media="screen,projection" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="Box">
            <div class="Naglowek">
                <p>Autor</p>
                <div class="Naglowek_gwiazdka">
                    <p>*</p>
                </div>
            </div>
            <div id="Autor">
                <div>
                    <div class="Dane">Imię</div>
                    <asp:TextBox ID="ImieAutora" runat="server">  
                    </asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator"
                        Text="Uzupełnij pole!" ControlToValidate="ImieAutora"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <div class="Dane">Nazwisko</div>
                    <asp:TextBox ID="NazwiskoAutora" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator" Text="Uzupełnij pole!" ControlToValidate="NazwiskoAutora">
                    </asp:RequiredFieldValidator>
                </div>

                <div>
                    <div class="Dane">E-mail</div>
                    <asp:TextBox ID="EmailAutora"
                        runat="server"></asp:TextBox><asp:RequiredFieldValidator
                            ID="RequiredFieldValidator3"
                            CssClass="Komunikat"
                            Font-Underline="true"
                            runat="server"
                            ErrorMessage="RequiredFieldValidator"
                            Text="Uzupełnij pole!" ControlToValidate="EmailAutora"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                        runat="server"
                        Text="Adres e-mail jest niepoprawny!"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        ControlToValidate="EmailAutora"
                        ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$">
                    </asp:RegularExpressionValidator>
                </div>
            </div>
        </div>

        <div class="Box">
            <div class="Naglowek">
                <p>Współautor</p>
            </div>
            <div id="Wspolautor">
                <div>
                    <div class="Dane">Imię</div>
                    <asp:TextBox ID="ImieWspolautora" runat="server"></asp:TextBox>                             
                </div>

                <div>
                    <div class="Dane">Nazwisko</div>
                    <asp:TextBox ID="NazwiskoWspolautora" runat="server"></asp:TextBox>
                   
                </div>
            </div>
        </div>

        <div class="Box">
            <div class="Naglowek">
                <p>Opiekun</p>
                <div class="Naglowek_gwiazdka">
                    <p>*</p>
                </div>
            </div>
            <div id="Opiekun">
                <div>
                    <div class="Dane">Imię</div>
                    <asp:TextBox ID="ImieOpiekuna" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator6"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator" Text="Uzupełnij pole!" ControlToValidate="ImieOpiekuna">         
                    </asp:RequiredFieldValidator>
                </div>

                <div>
                    <div class="Dane">Nazwisko</div>
                    <asp:TextBox ID="NazwiskoOpiekuna" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator" Text="Uzupełnij pole!" ControlToValidate="NazwiskoOpiekuna">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
        </div>

        <div class="Box">
            <div class="Naglowek">
                <p>Uczelnia/Szkoła</p>
                <div class="Naglowek_gwiazdka">
                    <p>*</p>
                </div>
            </div>
            <div id="Uczelnia">
                <div>
                    <div class="Dane">Nazwa</div>
                    <asp:TextBox ID="NazwaSzkoly" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator8"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator" Text="Uzupełnij pole!" ControlToValidate="NazwaSzkoly">         
                    </asp:RequiredFieldValidator>
                </div>

                <div>
                    <div class="Dane">Adres</div>
                    <asp:TextBox ID="AdresSzkoly" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator" Text="Uzupełnij pole!" ControlToValidate="AdresSzkoly">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
        </div>

        <div class="Box">
            <div class="Naglowek">
                <p>Dane referatu</p>
                <div class="Naglowek_gwiazdka">
                    <p>*</p>
                </div>
            </div>
            <div id="DaneReferatu">
                <div>
                    <div class="Dane">Tytuł</div>
                    <asp:TextBox ID="TytulReferatu" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator10"
                        CssClass="Komunikat"
                        Font-Underline="true"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator" Text="Uzupełnij pole!" ControlToValidate="TytulReferatu">         
                    </asp:RequiredFieldValidator>
                </div>

                <div>
                    <div class="Dane">Streszczenie</div>
                    <asp:TextBox ID="StreszczenieReferatu" runat="server" Rows="10" Columns="50" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11"
                        Font-Underline="true"
                        CssClass="Komunikat"
                        runat="server"
                        ErrorMessage="RequiredFieldValidator" Text="Uzupełnij pole!" ControlToValidate="StreszczenieReferatu">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="Button">
            <asp:Button ID="ButtonWyslij" runat="server" Text="Wyślij" OnClick="Zapisz" />
        </div>
    </form>
    <table>
        <thead>
            <tr>
                <th>
                    Autor
                </th>
                <th>
                    Wspolautor
                </th>
                <th>
                    Opiekun
                </th>
                <th>
                   Nazwa Szkoły/Uczelni
                </th>
                <th>
                   Tytuł Referatu
                </th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server" ItemType="Zajecia03_wf.Entities.Formularz">
            <ItemTemplate>
                <tr>
                <td>
                    <%# Item.ImieAutora %> <%# Item.NazwiskoAutora %>                    
                </td>
                    <td>
                    <%# Item.ImieWspolautora %><%# Item.NazwiskoWspolautora %>               
                </td>
                    <td>
                    <%# Item.ImieOpiekuna %><%# Item.NazwiskoOpiekuna %>                    
                </td>
                    <td>
                    <%# Item.NazwaUczelni %><%# Item.AdresUczelni %>                    
                </td>
                    <td>
                    <%# Item.TytulReferatu %>                    
                </td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>           
        </tbody>
        </table>
</body>
</html>
