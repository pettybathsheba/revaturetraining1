<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppPage.aspx.cs" Inherits="RegApp.AppPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:EntityDataSource ID="EntityDataSource1" runat="server">
        </asp:EntityDataSource>
        <asp:Table ID="Table1" runat="server" style="width: 30px">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
