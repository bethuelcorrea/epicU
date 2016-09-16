<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="challengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          FirstValue:
        <asp:TextBox ID="firstnumTextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        SecondValue:
        <asp:TextBox ID="secondNumberTextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="*" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="/" />
        <br />
        <br />
        <asp:Label ID="lbltxt" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
