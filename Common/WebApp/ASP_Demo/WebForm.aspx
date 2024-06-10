<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ASP_Demo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server">
            
        </asp:DropDownList>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
            
        </asp:CheckBoxList>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            
        </asp:RadioButtonList>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Width="149px" SelectionMode="Multiple">
            
        </asp:ListBox>
        <br />
        <asp:BulletedList ID="BulletedList1" runat="server">
            
        </asp:BulletedList>

        <asp:Button Text="Submit" runat="server" OnClick="Submit_Click" />
    </form>
</body>
</html>