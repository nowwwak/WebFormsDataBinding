<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntityDataSource.aspx.cs" Inherits="WebFormsDataBinding.EntityDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="CountriesDropDownList" runat="server" DataSourceID="CountriesEntityDataSource" DataTextField="Country">
        </asp:DropDownList>
        <asp:EntityDataSource ID="CountriesEntityDataSource" runat="server"
             ConnectionString="name=NORTHWNDEntities" DefaultContainerName="NORTHWNDEntities" EnableFlattening="false"
             EntitySetName="Customers" Select="DISTINCT it.[Country]">
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
