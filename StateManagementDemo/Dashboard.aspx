<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="StateManagementDemo.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>State Management Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Dashboard - Welcome to Developer's Cafe</h3>

            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            <br />
            <br />
                                              
             <%--Current User:--%>  
            Your Username is:
            <asp:Label ID="lblName" runat="server" Text="" ForeColor="Red"></asp:Label>                      

        </div>
    </form>
</body>
</html>
