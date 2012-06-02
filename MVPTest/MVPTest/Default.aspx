<%@ Page Language="C#" Inherits="MVPTest.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
<title>MVP-Easy Example for ASP.Net C#</title>
</head>
<body>
<form id="form1" runat="server">
<table>
<tr>
<th colspan="2">Calculate Area of Circle</th>
</tr>
<tr>
<td>Enter Radius</td>
<td><asp:TextBox ID="TextRadius" runat="server"></asp:TextBox></td>
</tr>
<tr>
<td>Result:</td>
<td><asp:Label ID="LabelResult" runat="server" ForeColor="red"></asp:Label></td>
</tr>
<tr align="right">
<td colspan="2"><asp:Button ID="ButtonResult" runat="server" Text="Get Area?" OnClick="ButtonResult_Click" /></td>
</tr>
</table>
</form>
</body>
</html>
