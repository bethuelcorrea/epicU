<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cs_asp_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is<asp:TextBox ID="firstTextBox1" runat="server"></asp:TextBox>
        equal to<asp:TextBox ID="secondlTextBox2" runat="server"></asp:TextBox>
        ?<br />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="are you cool?" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" />
        <br />
        <br />
        <asp:Label ID="lbltxt" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
