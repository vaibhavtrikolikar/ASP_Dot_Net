<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ASP_Demo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click" DisplayMode="LinkButton">
            <asp:ListItem Text="Google" Value="1"></asp:ListItem>
            <asp:ListItem Text="Microsoft" Value="2"></asp:ListItem>
            <asp:ListItem Text="Dell" Value="3"></asp:ListItem>
            <asp:ListItem Text="IBM" Value="4"></asp:ListItem>
        </asp:BulletedList>
    </form>
</body>
</html>
