<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cs_asp_014.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        this is some tex<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" />
        <br />
        <br />
        <asp:Label ID="lbltext" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
