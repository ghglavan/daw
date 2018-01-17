<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:LoginView ID="LoginView1" runat="server">
        
        <RoleGroups>
            <asp:RoleGroup Roles="Admin">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateEditButton="True" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="UserName" HeaderText="Username" ReadOnly="True" SortExpression="UserName" />
                            <asp:BoundField DataField="RoleName" HeaderText="RoleName"  SortExpression="RoleName" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:RoleGroup>
        </RoleGroups>
    </asp:LoginView>
   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
        SelectCommand="SELECT [Id], [UserName], [RoleName] FROM [View]"
        UpdateCommand="UPDATE [UsersInRoles] SET [RoleId] = (SELECT [RoleId] FROM Roles WHERE [RoleName] LIKE @RoleName) WHERE UserID LIKE @Id"
        ></asp:SqlDataSource>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
</asp:Content>

