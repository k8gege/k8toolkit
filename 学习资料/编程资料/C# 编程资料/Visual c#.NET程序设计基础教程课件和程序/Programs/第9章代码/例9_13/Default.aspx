<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="例9_13._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="AccessDataSource1" DataTextField="ProductName" 
            DataValueField="ProductID">
        </asp:DropDownList>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/Nwind.mdb" 
            SelectCommand="SELECT [ProductID], [ProductName] FROM [Products]">
        </asp:AccessDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            DataKeyNames="ProductID" DataSourceID="AccessDataSource2" Height="50px" 
            Width="125px">
            <Fields>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                    InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                    SortExpression="ProductName" />
                <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" 
                    SortExpression="SupplierID" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                    SortExpression="CategoryID" />
                <asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" 
                    SortExpression="QuantityPerUnit" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
                    SortExpression="UnitPrice" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" 
                    SortExpression="UnitsInStock" />
                <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" 
                    SortExpression="UnitsOnOrder" />
                <asp:BoundField DataField="ReorderLevel" HeaderText="ReorderLevel" 
                    SortExpression="ReorderLevel" />
                <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" 
                    SortExpression="Discontinued" />
                <asp:CommandField ShowEditButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
            ConflictDetection="CompareAllValues" DataFile="~/App_Data/Nwind.mdb" 
            DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = ? AND [ProductName] = ? AND (([SupplierID] = ?) OR ([SupplierID] IS NULL AND ? IS NULL)) AND (([CategoryID] = ?) OR ([CategoryID] IS NULL AND ? IS NULL)) AND (([QuantityPerUnit] = ?) OR ([QuantityPerUnit] IS NULL AND ? IS NULL)) AND (([UnitPrice] = ?) OR ([UnitPrice] IS NULL AND ? IS NULL)) AND (([UnitsInStock] = ?) OR ([UnitsInStock] IS NULL AND ? IS NULL)) AND (([UnitsOnOrder] = ?) OR ([UnitsOnOrder] IS NULL AND ? IS NULL)) AND (([ReorderLevel] = ?) OR ([ReorderLevel] IS NULL AND ? IS NULL)) AND [Discontinued] = ?" 
            InsertCommand="INSERT INTO [Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [Products] WHERE ([ProductID] = ?)" 
            UpdateCommand="UPDATE [Products] SET [ProductName] = ?, [SupplierID] = ?, [CategoryID] = ?, [QuantityPerUnit] = ?, [UnitPrice] = ?, [UnitsInStock] = ?, [UnitsOnOrder] = ?, [ReorderLevel] = ?, [Discontinued] = ? WHERE [ProductID] = ? AND [ProductName] = ? AND (([SupplierID] = ?) OR ([SupplierID] IS NULL AND ? IS NULL)) AND (([CategoryID] = ?) OR ([CategoryID] IS NULL AND ? IS NULL)) AND (([QuantityPerUnit] = ?) OR ([QuantityPerUnit] IS NULL AND ? IS NULL)) AND (([UnitPrice] = ?) OR ([UnitPrice] IS NULL AND ? IS NULL)) AND (([UnitsInStock] = ?) OR ([UnitsInStock] IS NULL AND ? IS NULL)) AND (([UnitsOnOrder] = ?) OR ([UnitsOnOrder] IS NULL AND ? IS NULL)) AND (([ReorderLevel] = ?) OR ([ReorderLevel] IS NULL AND ? IS NULL)) AND [Discontinued] = ?">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="ProductID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <DeleteParameters>
                <asp:Parameter Name="original_ProductID" Type="Int32" />
                <asp:Parameter Name="original_ProductName" Type="String" />
                <asp:Parameter Name="original_SupplierID" Type="Int32" />
                <asp:Parameter Name="original_CategoryID" Type="Int32" />
                <asp:Parameter Name="original_QuantityPerUnit" Type="String" />
                <asp:Parameter Name="original_UnitPrice" Type="Decimal" />
                <asp:Parameter Name="original_UnitsInStock" Type="Int16" />
                <asp:Parameter Name="original_UnitsOnOrder" Type="Int16" />
                <asp:Parameter Name="original_ReorderLevel" Type="Int16" />
                <asp:Parameter Name="original_Discontinued" Type="Boolean" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="SupplierID" Type="Int32" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="QuantityPerUnit" Type="String" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="UnitsInStock" Type="Int16" />
                <asp:Parameter Name="UnitsOnOrder" Type="Int16" />
                <asp:Parameter Name="ReorderLevel" Type="Int16" />
                <asp:Parameter Name="Discontinued" Type="Boolean" />
                <asp:Parameter Name="original_ProductID" Type="Int32" />
                <asp:Parameter Name="original_ProductName" Type="String" />
                <asp:Parameter Name="original_SupplierID" Type="Int32" />
                <asp:Parameter Name="original_CategoryID" Type="Int32" />
                <asp:Parameter Name="original_QuantityPerUnit" Type="String" />
                <asp:Parameter Name="original_UnitPrice" Type="Decimal" />
                <asp:Parameter Name="original_UnitsInStock" Type="Int16" />
                <asp:Parameter Name="original_UnitsOnOrder" Type="Int16" />
                <asp:Parameter Name="original_ReorderLevel" Type="Int16" />
                <asp:Parameter Name="original_Discontinued" Type="Boolean" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="ProductID" Type="Int32" />
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="SupplierID" Type="Int32" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="QuantityPerUnit" Type="String" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="UnitsInStock" Type="Int16" />
                <asp:Parameter Name="UnitsOnOrder" Type="Int16" />
                <asp:Parameter Name="ReorderLevel" Type="Int16" />
                <asp:Parameter Name="Discontinued" Type="Boolean" />
            </InsertParameters>
        </asp:AccessDataSource>
    
    </div>
    </form>
</body>
</html>
