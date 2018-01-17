<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewsSearch.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <asp:SqlDataSource ID="SDSSearch" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
        SelectCommand="Select News_v.author as author, News_v.title as title , News_v.category as category, News_v.pub_date pub_date, News_v.content as content from News_v order by News_v.pub_date desc">
    </asp:SqlDataSource>

    <asp:Label ID="LSelect" runat="server" Text=""></asp:Label>
    <br />
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SDSSearch">
        <HeaderTemplate>
            Search results:
        </HeaderTemplate>
        <ItemTemplate>
            <div style="padding: 10px; background-color: #e6ff99">
                <h3><%# DataBinder.Eval(Container.DataItem, "Title")%> by <%# DataBinder.Eval(Container.DataItem, "author")%></h3>
            
                <div>
                    <asp:LinkButton  CssClass="label label-success" ID="Cat" runat="server" OnClick="Search_Category"  CommandArgument = '<%#  DataBinder.Eval(Container.DataItem, "category") %>'>
                         <%# DataBinder.Eval(Container.DataItem, "category")%> 
                    </asp:LinkButton>
                </div>
                <div>
                    Pub date: <%# DataBinder.Eval(Container.DataItem, "pub_date")%>
                </div>

                <div>
                    Content: <%# DataBinder.Eval(Container.DataItem, "content")%>
                </div>
             </div>
        </ItemTemplate>
        <SeparatorTemplate>
            <br />
        </SeparatorTemplate>
    </asp:Repeater>
</asp:Content>

