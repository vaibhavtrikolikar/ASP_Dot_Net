<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ASP_Demo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <b>Age</b>
                </td>
                <td>:<asp:TextBox ID="txtAge" runat="server" Width="150px">
                </asp:TextBox>
                    <asp:RangeValidator ID="RangeValidatorAge" runat="server"
                        ErrorMessage="Age must be between 1 & 100"
                        MinimumValue="1" MaximumValue="100"
                        ControlToValidate="txtAge" Type="Integer"
                        ForeColor="Red" Display="Dynamic">
                    </asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge"
                        runat="server" ErrorMessage="Age is required"
                        ControlToValidate="txtAge" ForeColor="Red"
                        Display="Dynamic">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>              
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
