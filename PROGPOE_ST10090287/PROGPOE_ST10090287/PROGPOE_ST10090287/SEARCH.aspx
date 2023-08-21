<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SEARCH.aspx.cs" Inherits="PROGPOE_ST10090287.SEARCH" %>

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
.searchbtn{
  background-color: #04AA6D;
  color: white;
  padding: 16px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
  opacity: 0.9;
}

.savebtn {
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
  <div class="container">
    <h1>SEARCH MODULES</h1>
    <p>Please Fill In Modules.</p>
    <hr>

      

    <label for="SEARCH MODULES"><b>SEARCH MODULES</b></label>
   <asp:TextBox ID="ModuleS" runat="server"></asp:TextBox>

   
    
      <asp:ListBox ID="searchlist" runat="server" Height="153px" Width="329px"></asp:ListBox>
        </div>
    <hr>
     
        <asp:Button ID="Button122" runat="server" Text="Search" Width="780px" OnClick="Button122_Click" />
    </form>
     
    <br />
    
  
  </div>
</body>
</html>
