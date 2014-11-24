<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StateManagementDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>State Management Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Welcome to Developer's Cafe</h3>

            Username:
            <asp:TextBox ID="txtUser" runat="server" required></asp:TextBox>
            <br />
            Password: &nbsp;<asp:TextBox ID="txtPass" runat="server" TextMode="Password" required></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

            <br />
            <br />

            <%--Last Login:--%>
                  <asp:Label ID="lblVisit" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <br />

            <%--Online Visitors:--%> 
            Online Visitors:                 
            <asp:Label ID="lblCounter" runat="server" Text="" ForeColor="Red"></asp:Label>
                        
            <br />
            <br />
            <%--Number of Wrong Login Attempts:--%>
            <asp:Label ID="lblAttempt" runat="server" Text="" ForeColor="Red"></asp:Label>


        </div>
    </form>
</body>
</html>
