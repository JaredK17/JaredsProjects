<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN1.aspx.cs" Inherits="PROGPOE_ST10090287.LOGIN1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
    <style>
                  {box-sizing: border-box}

/* Add padding to containers */
.container {
  padding: 16px;
}
input[type=text]:focus, input[type=password]:focus {
  background-color: #ddd;
  outline: none;

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  display: inline-block;
  border: none;
  background: #f1f1f1;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h2>LOGIN TO YOUR ACCOUNT</h2>
    <br />
    <br />
     <div>
 
            <table style="width: 100%">
                <tr>
                    <td style="width: 163px">UserName:</td>
                    <td>
                        <asp:TextBox ID="userbox" runat="server" CssClass="form-poshytip" placeholder="enter username"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 163px">Password:</td>
                    <td>
                        <asp:TextBox ID="passwordbox" TextMode="Password" runat="server" CssClass="form-poshytip" placeholder="enter password"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 163px"> </td>
                    <td>
                        <asp:Button OnClick="submitbtn_Click"    ID="submitbtn" runat="server" Text="Submit" Width="326px" />
                    </td>
                </tr>
            </table>
          </div>
 
  
   
    </div>
    </form>
</body> 
</html>
