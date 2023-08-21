<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MANAGEMODULES.aspx.cs" Inherits="PROGPOE_ST10090287.MANAGEMODULES" %>

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

/* Add a blue text color to links */
a {
  color: dodgerblue;
}

/* Set a grey background color and center the text of the "sign in" section */
.signin {
  background-color: #f1f1f1;
  text-align: center;

}
/* Add a black background color to the top navigation */
.topnav {
  background-color: #333;
  overflow: hidden;
}

/* Style the links inside the navigation bar */
.topnav a {
  float: left;
  display: block;
  color: #f2f2f2;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
}

/* Change the color of links on hover */
.topnav a:hover {
  background-color: #ddd;
  color: black;
}

/* Add an active class to highlight the current page */
.topnav a.active {
  background-color: #04AA6D;
  color: white;
}

/* Hide the link that should open and close the topnav on small screens */
.topnav .icon {
  display: none;
}
    </style>
    
</head>
    
 <div class="topnav" id="myTopnav">
  <a href="LOGIN1.aspx" class="active">login</a>
  <a href="REGISTER1.aspx">Registration</a>
  <a href="MANAGEMODULES.aspx">Manage Modules</a>
  <a href="SEARCH.aspx">Search modules</a>
  <a href="Reminder.aspx">Reminder</a>
  <a href="javascript:void(0);" class="icon" onclick="myFunction()">
    <i class="fa fa-bars"></i>
  </a>
</div>

<body>
    <form id="form1" runat="server">
        
      

    <label for="MODULECODE"><b>MODULECODE</b></label>
    <asp:TextBox ID="MCODE" runat="server"></asp:TextBox>

    <label for="MODULENAME"><b>MODULENAME</b></label>
     <asp:TextBox ID="MNAME" runat="server"></asp:TextBox>

    <label for="CREDITS"><b>CREDITS</b></label>
    <asp:TextBox ID="CRED" runat="server"></asp:TextBox>
            
    <label for="HOURS"><b>HOURS</b></label>
     <asp:TextBox ID="HR" runat="server"></asp:TextBox>

     <label for="WEEKS"><b>WEEKS</b></label>
      <asp:TextBox ID="WK" runat="server"></asp:TextBox>

       <label for="DATE"><b>DATE</b></label>
      <asp:TextBox TextMode="Date" ID="DT" runat="server"></asp:TextBox>
            <br />
              
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
              <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <br />

              

   
    <

        
    </form>
</body>
</html>
