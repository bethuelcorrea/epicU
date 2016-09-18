<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cs_asp_017.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Name<asp:TextBox ID="firstInput" runat="server">name</asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Calendar ID="myCalendar" runat="server" SelectedDate="2016-09-19" VisibleDate="2016-09-17">
            <TodayDayStyle BackColor="Red" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" />
        <br />
        <br />
        <asp:Label ID="lbltext" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
