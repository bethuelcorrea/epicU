<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div><img src="epic-spies-logo.jpg" height="150px" />
        <br />
        <strong class="newStyle1">Asset Performance Tracker</strong><br />
        <br />
        Asset Name<asp:TextBox ID="AssetNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Election Rigged<asp:TextBox ID="electionRiggedtext" runat="server"></asp:TextBox>
        <br />
        <br />
       Acts of Subterfuge Performed:<asp:TextBox ID="actsPerformed" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="lbltext" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
