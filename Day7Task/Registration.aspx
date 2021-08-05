<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 125px;
        }
        .auto-style2 {
            width: 296px;
            height: 45px;
        }
        .auto-style3 {
            width: 125px;
            height: 50px;
        }
        .auto-style4 {
            height: 50px;
        }
        .auto-style5 {
            width: 125px;
            height: 55px;
        }
        .auto-style6 {
            height: 55px;
        }
    </style>
    <h1 style="margin-left: 202px" class="auto-style2">&nbsp;&nbsp;&nbsp; Registration Form</h1>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
     <table style="height: 15px; width: 777px">
         <tr>
         <td class="auto-style3">
             <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
             </td>
        
         <td class="auto-style4">
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
              </td>
        
         <td class="auto-style4">
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
              </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
              </td>
       
         <td class="auto-style4">
             <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                 <asp:ListItem>Male</asp:ListItem>
                 <asp:ListItem>Female</asp:ListItem>
             </asp:RadioButtonList>
              </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
              </td>
         
         <td class="auto-style4">
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label5" runat="server" Text="State"></asp:Label>
              </td>
         
         <td class="auto-style4">
             <asp:DropDownList ID="DropDownList1" runat="server">
                 <asp:ListItem>TamilNadu</asp:ListItem>
                 <asp:ListItem>Kerala</asp:ListItem>
                 <asp:ListItem>AndhraPradhesh</asp:ListItem>
                 <asp:ListItem>Telangana</asp:ListItem>
                 <asp:ListItem>Karnataka</asp:ListItem>
             </asp:DropDownList>
              </td>
         </tr>
          <tr>
         <td class="auto-style5"></td>
      
         <td class="auto-style6">
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
              </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
              </td>
      
         <td class="auto-style4">
             <asp:DropDownList ID="DropDownList2" runat="server">
             </asp:DropDownList>
              </td>
         </tr>
          <tr>
         <td class="auto-style1">
             <asp:Label ID="Label8" runat="server" Text="Submit"></asp:Label>
              </td>
        
         <td>
             <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
              </td>
         </tr>

     </table>   
      
      
             <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
  
        <br />
   
    </form>
</body>
</html>
