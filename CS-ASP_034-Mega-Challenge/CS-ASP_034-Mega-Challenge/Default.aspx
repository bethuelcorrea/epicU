<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_034_Mega_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Your Bet<asp:TextBox ID="betTextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="pullButton1" runat="server" OnClick="pullButton1_Click" Text="Pull The Lever" />
        <br />
        <br />
        <asp:Label ID="resultlbl" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneylbl" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherries - x2 Your Bet<br />
        2 Cherries -x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot- x100 Your Bet<br />
        However....if there&#39;s even one Bar you win nothing</div>
    </form>
</body>
</html>
