<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            background-color: #FF3300;
        }
        .auto-style2 {
            width: 436px;
            height: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Head Line 1</h1>
    
    </div>
        <p>
            Head Line2</p>
        <p>
            head Line 3</p>
        <p>
            Head Line 4
        </p>
        <p>
            Head Line5</p>
        <p>
            Head Line6</p>
        <p>
            This is some text that I want t<span class="auto-style1"> apply</span> a style.</p>
        <p>
            <a href="http://www.google.com">add a link</a></p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://github.com/bethuelcorrea/epicU/commits/master">This is another link</asp:HyperLink>
        </p>
        <p>
            <img alt="back the blue" class="auto-style2" src="back-the-blue.jpg" /></p>
    </form>
</body>
</html>
