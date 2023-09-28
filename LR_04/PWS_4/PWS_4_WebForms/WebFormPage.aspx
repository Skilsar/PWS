<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPage.aspx.cs" Inherits="PWS_4_WebForms.WebFormPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>webform</title>
</head>
<body>
    <div>
        <p>Add</p>
        <form id="FormAdd" runat="server">
            <input type="text" id="x" runat="server" />
            <input type="text" id="y" runat="server" />
            <button type="submit">Submit</button>
        </form>
    </div>
    <div id="addResult" runat="server" style="margin-top: 20px;">Result:</div>
</body>
</html>
