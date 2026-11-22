<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="例9_6._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        按城市查询：<asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="提交" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource1" 
            AutoGenerateColumns="False" DataKeyNames="CustomerID">
            <Columns>
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" 
                    SortExpression="CompanyName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" 
                    SortExpression="CustomerID" />
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/Nwind.mdb" onselecting="AccessDataSource1_Selecting" 
            
            SelectCommand="SELECT CompanyName, City, CustomerID FROM Customers WHERE (City = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtCity" Name="?" PropertyName="Text" />
            </SelectParameters>
        </asp:AccessDataSource>
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
