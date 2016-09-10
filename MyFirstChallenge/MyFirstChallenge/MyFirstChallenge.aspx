<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyFirstChallenge.aspx.cs" Inherits="MyFirstChallenge.MyFirstChallenge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Challenge</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How old are you?<asp:TextBox ID="AgeTextBox" runat="server"></asp:TextBox>
    
        <br />
        <br />
        How much money do you have in your pocket?<asp:TextBox ID="MoneyTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click me" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
