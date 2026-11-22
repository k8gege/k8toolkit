<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsOrders.aspx.cs" Inherits="例9_10.DetailsOrders" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="OrderID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="OrderID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="OrderID" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" 
                    SortExpression="CustomerID" />
                <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" 
                    SortExpression="OrderDate" />
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/Nwind.mdb" 
            SelectCommand="SELECT [OrderID], [CustomerID], [OrderDate] FROM [Orders] WHERE ([CustomerID] = ?)">
            <SelectParameters>
                <asp:QueryStringParameter Name="CustomerID" QueryStringField="custid" 
                    Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
    
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Master.aspx">返回至客户</asp:HyperLink>
    </form>
</body>
</html>
