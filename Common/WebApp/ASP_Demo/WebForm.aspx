﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ASP_Demo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Text="Select User" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Admin" Value="Admin"></asp:ListItem>
            <asp:ListItem Text="Non-Admin" Value="Non-Admin"></asp:ListItem>
        </asp:DropDownList>
        <asp:Panel ID="AdminPanel" runat="server">
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="AdminGreeting" runat="server" Font-Size="XX-Large"
                            Text="You are logged in as an administrator">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="AdminNameLabel" runat="server" Text="Admin Name:">
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="AdminNameTextBox" runat="server" Text="Tom">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="AdminRegionLabel" runat="server" Text="Admin Region:">
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="AdminRegionTextBox" runat="server" Text="Asia">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="AdminActionsLabel" runat="server" Text="Actions:">
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="AdminActionsTextBox" runat="server" Font-Size="Medium" TextMode="MultiLine"
                            Text="There are 4 user queries to be answered by the end of Dcemeber 25th 2013."
                            Font-Bold="True"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="NonAdminPanel" runat="server">
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="NonAdminGreeting" runat="server" Font-Size="XX-Large"
                            Text="Welcome Tom!">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="NonAdminNameLabel" runat="server" Text="User Name:">
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="NonAdminNameTextBox" runat="server" Text="Mike">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="NonAdminRegionLabel" runat="server" Text="User Region:">
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="NonAdminRegionTextBox" runat="server" Text="United Kingdom">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="NonAdminCityLabel" runat="server" Text="City:">
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="NonAdminCityTextBox" runat="server" Text="London">
                        </asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
