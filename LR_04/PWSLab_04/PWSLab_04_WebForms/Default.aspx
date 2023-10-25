<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PWSLab_04_WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>PWSLab_04</title>
    <script src="Scripts/jquery.js"></script>
    <script>
        function getSum_Ajax() {
            const data = {
                x: parseInt($("#x2").val()),
                y: parseInt($("#y2").val())
            };
            $.ajax({
                url: "http://localhost:31897/Simplex.asmx/ADDS",
                type: "POST",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(data),
                success: result => {
                    $("#result2").val(result.d);
                },
                error: error => {
                    $("#result2").val(error.responseJSON.Message);
                    console.log(error);
                }
            })
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
            <div>
        x:
        <asp:TextBox runat="server" ID="x" />
        <br /><br />
        y:
        <asp:TextBox runat="server" ID="y" />
        <br /><br />
        
    </div>
    <br />
    <div>
        result:
        <asp:TextBox runat="server" ID="result" />
    </div>
    <hr />
    <asp:Button runat="server" ID="sum" OnClick="sum_Click" Text="Sum" />
<asp:Button runat="server" ID="concat" OnClick="sum_Click_concat" Text="Concat" />
<asp:Button runat="server" ID="Button2" OnClick="DetermineAndOperate" Text="Adds" />
        <hr />
        <%--<div>
            x:
            <input type="text" ID="x2" />
            <br /><br />
            y:
            <input type="text" ID="y2" />
            <br /><br />
            <input type="button" onclick="getSum_Ajax()" value="ajax" />
        </div>
        <br />
        <div>
             result:
            <input type="text" ID="result2" />
        </div>--%>
    </form>
</body>
</html>
