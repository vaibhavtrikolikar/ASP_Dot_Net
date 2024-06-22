<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ASP_Demo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 163px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="auto-style1">
                    <b>Password</b>
                </td>
                <td>:<asp:TextBox ID="txtPassword" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><strong>Retype Password</strong></td>
                <td>:<asp:TextBox ID="txtRetypePassword" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                        ErrorMessage="Password and Retype Password must match"
                        ControlToValidate="txtRetypePassword" ControlToCompare="txtPassword"
                        Type="String" Operator="Equal" ForeColor="Red">
                    </asp:CompareValidator>
                </td>
            </tr>      
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSave" runat="server" Text="Save" Width="100px"
                        OnClick="btnSave_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblStatus" runat="server" Font-Bold="true">
                    </asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
