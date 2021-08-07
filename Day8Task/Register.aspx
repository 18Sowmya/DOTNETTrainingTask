<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        #table 
        {
           
            background-color:blanchedalmond;
        }
        .auto-style1 {
            width: 125px;
        }
        .auto-style2 {
            width: 724px;
            height: 45px;
            margin-left: 345px;
        }
        .auto-style3 {
            width: 125px;
            height: 50px;
        }
        .auto-style4 {
            height: 50px;
            width: 963px;
        }
        .auto-style5 {
            width: 125px;
            height: 55px;
        }
        .auto-style6 {
            height: 55px;
            width: 963px;
        }
        .auto-style7 {
            position: absolute;
            top: 194px;
            left: 260px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 285px;
            left: 263px;
            z-index: 1;
        }
        .auto-style9 {
            width: 125px;
            height: 64px;
        }
        .auto-style10 {
            height: 64px;
            width: 963px;
        }
        .auto-style11 {
            width: 963px;
        }
        .auto-style12 {
            position: absolute;
            top: 86px;
            left: 316px;
            height: 15px;
            width: 777px;
            z-index: 1;
        }
        .auto-style13 {
            width: 125px;
            height: 2px;
        }
        .auto-style14 {
            height: 2px;
            width: 963px;
        }
        </style>
    <h1 class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registration Form</h1>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
     <table border="1" id="table" class="auto-style12">
         <tr>
         <td class="auto-style3">
             <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
             </td>
        
         <td class="auto-style4">
             <asp:TextBox ID="Fname" runat="server"></asp:TextBox>
             &nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Fname" ErrorMessage="Enter a firstname" ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
              </td>
        
         <td class="auto-style4">
             <asp:TextBox ID="Lname" runat="server"></asp:TextBox>
              &nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Lname" ErrorMessage="Enter a lastname" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
         </tr>

               <tr>
         <td class="auto-style3">
             <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
              </td>
         
         <td class="auto-style4">
             <asp:TextBox ID="Age" runat="server" MaxLength="2" TextMode="Number"></asp:TextBox>
              &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Age" ErrorMessage="Please enter age" ForeColor="Red"></asp:RequiredFieldValidator>
              &nbsp;
             <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Age" ErrorMessage="Not eligible" MaximumValue="60" MinimumValue="18" ForeColor="Red"></asp:RangeValidator>
              </td>
         </tr>

          <tr>
         <td class="auto-style13">
             <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
              </td>
       
         <td class="auto-style14">
             <asp:RadioButtonList ID="Gender" runat="server">
                 <asp:ListItem>Male</asp:ListItem>
                 <asp:ListItem>Female</asp:ListItem>
             </asp:RadioButtonList>
          
              <br />
          
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Gender" CssClass="auto-style7" ErrorMessage="Select the gender" ForeColor="Red"></asp:RequiredFieldValidator>
          
              </td>
         </tr>
    
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label5" runat="server" Text="Martial Status"></asp:Label>
              </td>
         
         <td class="auto-style4">
             <asp:RadioButtonList ID="Martial" runat="server">
                 <asp:ListItem>Married</asp:ListItem>
                 <asp:ListItem>UnMarried</asp:ListItem>
             </asp:RadioButtonList>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Martial" CssClass="auto-style8" ErrorMessage="Select the Marital status" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;</td>
         </tr>
          <tr>
         <td class="auto-style5">
             <asp:Label ID="Label9" runat="server" Text="EmailID"></asp:Label>
              </td>
      
         <td class="auto-style6">
             <asp:TextBox ID="Email" runat="server" TextMode="Email"></asp:TextBox>
       
              &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Email" ErrorMessage="Please enter emailid" ForeColor="Red"></asp:RequiredFieldValidator>
       
              &nbsp;
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" ErrorMessage="Invalid EmailID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
       
              </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label7" runat="server" Text="Pincode"></asp:Label>
              </td>
      
         <td class="auto-style4">
             <asp:TextBox ID="Pincode" runat="server"></asp:TextBox>
       
              &nbsp;
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Pincode" ErrorMessage="Invalid pincode" ForeColor="Red" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
       
              </td>
         </tr>
          <tr>
         <td class="auto-style3">
             <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
              </td>
      
         <td class="auto-style4">
             <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
       
              &nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Password" ErrorMessage="Please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
       
              </td>
         </tr>
          <tr>
         <td class="auto-style9">
             <asp:Label ID="Label10" runat="server" Text="ConfirmPassword"></asp:Label>
              </td>
      
         <td class="auto-style10">
             <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
       
              &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Enter the confirm password" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" ErrorMessage="Password and Confirm Password not matched" ForeColor="Red"></asp:CompareValidator>
       
              </td>
         </tr>
           <tr>
         <td class="auto-style3">
             <asp:Label ID="Label11" runat="server" Text="Occupation"></asp:Label>
              </td>
      
         <td class="auto-style4">
&nbsp;
             <asp:CheckBoxList ID="CheckBoxOccu" runat="server">
                 <asp:ListItem>Developer</asp:ListItem>
                 <asp:ListItem>Testing</asp:ListItem>
                 <asp:ListItem>Support</asp:ListItem>
             </asp:CheckBoxList>
       
              </td>
         </tr>
          <tr>
         <td class="auto-style1">
             <asp:Label ID="Label8" runat="server" Text="Submit"></asp:Label>
              </td>
        
         <td class="auto-style11">
             <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"  />
              </td>
         </tr>

     </table>   
      
      
        <br />
   
    </form>
</body>
</html>
