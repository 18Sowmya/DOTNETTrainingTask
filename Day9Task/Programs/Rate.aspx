<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rate.aspx.cs" Inherits="WebApplication1.Rate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem >Select</asp:ListItem>
                    <asp:ListItem Value="Gold">Gold</asp:ListItem>
                    <asp:ListItem Value="Silver">Silver</asp:ListItem>
                    </asp:DropDownList>
             <br />
             <br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
