<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cs_asp_012.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        is<asp:TextBox ID="firstTextBox1" runat="server"></asp:TextBox>
&nbsp;equal to<asp:TextBox ID="secondTextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="are you old?" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        <asp:Label ID="lbltext" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
