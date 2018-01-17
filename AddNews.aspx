<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

    <div style="padding: 10px">
        <asp:Label ID="Label7" runat="server" Text="Title:"></asp:Label>
        <br />
        <asp:TextBox ID="TitleBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="TitleBox" runat="server" ErrorMessage="Title si required" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div style="padding: 10px">
        <asp:Label ID="Label2" runat="server" Text="Category:"></asp:Label>
        <br />
        <asp:TextBox ID="CategoryBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="CategoryBox" runat="server" ErrorMessage="Category si required" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div style="padding: 10px">
        <asp:Label ID="Label1" runat="server" Text="Content:"></asp:Label>
        <br />
        <asp:TextBox ID="ContentBox" Rows="20" Columns="100" TextMode="MultiLine" style="overflow: scroll" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ContentBox" runat="server" ErrorMessage="Content si required" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>


    <div style="padding: 10px">
        <asp:Button ID="AddButton" runat="server" Text="Add News" OnClick="AddButton_Click" />
    </div>
    <div style="padding: 10px">
        <asp:Label ID="LAnswer" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

