<%@ Page Language="C#" EnableSessionState="False" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ASP_Demo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <table>
                <tr>
                    <td colspan="2">
                        <h1>This is WebForm1</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Name</b>
                    </td>
                    <td class="auto-style1">:<asp:TextBox ID="txtName" runat="server" Width="234px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email</b>
                    </td>
                    <td class="auto-style1">:<asp:TextBox ID="txtEmail" runat="server" Width="232px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">                        
                        <asp:Button ID="Button2" runat="server" Text="Open Form 2" OnClick="Button2_Click" Width="308px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">                        
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
