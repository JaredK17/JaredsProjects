<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="REGISTER1.aspx.cs" Inherits="PROGPOE_ST10090287.REGISTER1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  
    <title></title>  
    <style> 
  <style>
         {box-sizing: border-box}

/* Add padding to containers */
.container {
  padding: 16px;
}

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  display: inline-block;
  border: none;
  background: #f1f1f1;
}

input[type=text]:focus, input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

/* Overwrite default styles of hr */
hr {
  border: 1px solid #f1f1f1;
  margin-bottom: 25px;
}

/* Set a style for the submit/register button */
.registerbtn {
  background-color: #04AA6D;
  color: white;
  padding: 16px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
  opacity: 0.9;
}

.registerbtn:hover {
  opacity:1;
}
    </style>
</head>  
<body>  
    <form id="form1" runat="server">  
        
            
                     
                      <label for="NAME"><b>NAME</b></label>  
        <br /><br />
                     <asp:TextBox ID="USERNAME" runat="server" Width="972px"></asp:TextBox> 
        
        <br /><br />
                 
                      <label for="PASSWORD"><b>PASSWORD</b></label>  
        <br /><br />
                      <asp:TextBox ID="PASSWORD" runat="server" Width="966px"></asp:TextBox>  
                 
                 
        <br /><br />             
                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" Width="647px" />  
                    
                
            
      
    </form>  
</body>  
</html>  