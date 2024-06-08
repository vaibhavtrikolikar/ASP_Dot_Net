<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlContinents" DataTextField="ContinentName" DataValueField="ContinentId" Width="250px" runat="server" OnSelectedIndexChanged="ddlContinents_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="ddlCountries" DataTextField="CountryName" DataValueField="CountryId" Width="250px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountries_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="ddlCities" DataTextField="CityName" DataValueField="CityId" Width="250px" runat="server" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged"></asp:DropDownList>
    </form>
</body>
</html>