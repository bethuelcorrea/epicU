<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostageCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width<asp:TextBox ID="widthTextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        Height<asp:TextBox ID="heightTextBox2" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        length<asp:TextBox ID="lengthTextBox3" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton1" runat="server" AutoPostBack="True" GroupName="shipOptions" Text="Ground" OnCheckedChanged="groundRadioButton1_CheckedChanged" />
        <br />
        <asp:RadioButton ID="airRadioButton2" runat="server" AutoPostBack="True" GroupName="shipOptions" Text="Air" OnCheckedChanged="airRadioButton2_CheckedChanged" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton3" runat="server" AutoPostBack="True" GroupName="shipOptions" Text="Next Day" OnCheckedChanged="nextDayRadioButton3_CheckedChanged" />
        <br />
        <br />
        <asp:Label ID="lbltext" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
