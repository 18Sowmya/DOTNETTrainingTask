<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ending.aspx.cs" Inherits="WebApplication1.Ending" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
       .ending 
        {
           
            background-color:blanchedalmond;
        }
        .auto-style1 {
            background-color: blanchedalmond;
            height: 501px;
        }
        .auto-style2 {
            position: absolute;
            top: 139px;
            left: 520px;
            z-index: 1;
            width: 291px;
            height: 57px;
        }
        </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Size="Larger" ForeColor="#CC0000" Text="Thank You for Submitting "></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
