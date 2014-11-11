<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StateManagementDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>State Management Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Login Page - Please enter your credentials to login</h3>
        
        Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        Password: &nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"  />

        <br />        
        <br />
        
        Welcome Message:
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

        
        <br />
        <br />

        Number of Login Attempts:
        <asp:Label ID="lblAttempt" runat="server" Text=""></asp:Label>

        Visitors Count:
        <asp:Label ID="lblCount" runat="server" Text=""></asp:Label>
        
    </div>
    </form>
</body>
</html>
