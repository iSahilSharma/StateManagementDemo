<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="StateManagementDemo.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>State Management Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>[State Management Demo]</h3>

            HTML Control TextBox: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtHTML" type="text" />

            <br /><br />

            HTML Server Control TextBox: &nbsp;  
            <input id="txtServer" type="text" runat="server" />

            <br />
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
