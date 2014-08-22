<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MathsPage.aspx.cs" Inherits="MathsWebsite.MathsPage" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Maths Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
            </AjaxSettings>
        </telerik:RadAjaxManager>
        <telerik:RadScriptManager runat="server" ID="RadScriptManager"></telerik:RadScriptManager>
    <div>
        <table>
            <tr>
                <td>Number 1</td>
                <td>:</td>
                <td>
                    <telerik:RadTextBox ID="txtNumber1" runat="server"></telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>Number 2</td>
                <td>:</td>
                <td>
                    <telerik:RadTextBox ID="txtNumber2" runat="server"></telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <telerik:RadButton ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"></telerik:RadButton>
                </td>
                <td></td>
                <td>
                    <telerik:RadButton ID="btnSubtract" runat="server" Text="Subtract" OnClick="btnSubtract_Click"></telerik:RadButton>
                </td>
                <td></td>
                <td>
                    <telerik:RadButton ID="btnMultiply" runat="server" Text="Multiply" OnClick="btnMultiply_Click"></telerik:RadButton>
                </td>
                <td>
                    <telerik:RadTextBox ID="txtResult" runat="server"></telerik:RadTextBox>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
