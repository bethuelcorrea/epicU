<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
    <link type="text/css" rel="stylesheet" href="main.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="epic-spies-logo.jpg" />
        <br />
        <br />
        <span class="auto-style1">Spy New Assignment Form<br />
        </span>
        <br />
        Spy Code Name:<asp:TextBox ID="codeName" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:<asp:TextBox ID="assignname" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment<asp:Calendar ID="endCurrentAssignment" runat="server"></asp:Calendar>
        <br />
        Start Date of New Assignment<br />
        <asp:Calendar ID="startNewAssignment" runat="server"></asp:Calendar>
        <br />
        Projected End Date of New Assingment.<br />
        <asp:Calendar ID="projectedAssignment" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="lblresult" runat="server"></asp:Label>
        <br />    
    </div>
    </form>
</body>
</html>
