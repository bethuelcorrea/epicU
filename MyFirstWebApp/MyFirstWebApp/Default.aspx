﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        What is your first Name?<asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        What is your Last Name?<asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="button1" runat="server" OnClick="button1_Click" Text="Click Me" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        </div>
    </form>
</body>
</html>
