<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ASP_Demo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <strong>Enter User Name:&nbsp;
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" UseSubmitBehavior="False" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmt" runat="server" Text="Submit" OnClick="btnSubmt_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </strong>
    </form>
</body>
</html>
