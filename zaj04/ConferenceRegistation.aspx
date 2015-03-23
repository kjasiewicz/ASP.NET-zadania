<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConferenceRegistation.aspx.cs" Inherits="zaj04.ConferenceRegistation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView
        ID="FormView1"
        runat="server"
        DataSourceID="ObjectDataSource1"
        DefaultMode="Insert"
        ItemType="zaj04.ViewModel.ConferenceViewModel" OnItemInserted="FormView1_ItemInserted">

        <InsertItemTemplate>
            <div class="form-group">
                <label>AuthorFirstName:</label>
                <asp:TextBox ID="AuthorFirstNameDynamicControl" runat="server" CssClass="form-control" Text="<%# BindItem.AuthorFirstName %>"></asp:TextBox>            
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="AuthorFirstNameDynamicControl" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                <br />
            </div>
            <div class="form-group">
            <label>AuthorLastName:</label>
                <asp:TextBox ID="AuthorLastNameDynamicControl" runat="server" CssClass="form-control"></asp:TextBox>            
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="AuthorLastNameDynamicControl" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
                </div>
            <div class="form-group">
            AuthorMail:
            <asp:DynamicControl ID="AuthorMailDynamicControl" runat="server" DataField="AuthorMail" Mode="Insert" ValidationGroup="Insert" />
            <br />
                </div>
            ArticleTitle:
            <asp:DynamicControl ID="ArticleTitleDynamicControl" runat="server" DataField="ArticleTitle" Mode="Insert" ValidationGroup="Insert" />
            <br />
            ArticleAbstract:
            <asp:DynamicControl ID="ArticleAbstractDynamicControl" runat="server" DataField="ArticleAbstract" Mode="Insert" ValidationGroup="Insert" />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" ValidationGroup="Insert" />
            &nbsp;
        </InsertItemTemplate>
        <EmptyDataTemplate>
            Dziękujemy
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="new" Text="Zarejestruj się ponownie" ValidationGroup="Insert" />

        </EmptyDataTemplate>

    </asp:FormView>
    <asp:ObjectDataSource
        ID="ObjectDataSource1"
        runat="server"
        DataObjectTypeName="zaj04.ViewModel.ConferenceViewModel"
        InsertMethod="Register"
        OldValuesParameterFormatString="original_{0}"
        SelectMethod="Get"
        SelectCountMethod="GetCount"
        TypeName="zaj04.BLL.ConferenceService"
        EnablePaging="True"></asp:ObjectDataSource>
    <asp:GridView
        ID="GridView1"
        runat="server"
        AllowPaging="True"
        DataSourceID="ObjectDataSource1"
        PageSize="2"
        CssClass="table table-striped">
    </asp:GridView>
</asp:Content>
