<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_023.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How do I Work on Projects<asp:TextBox ID="hoursTextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Hours" />
        <br />
        <br />
        <asp:Label ID="lblText" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
