<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reminder.aspx.cs" Inherits="PROGPOE_ST10090287.Reminder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        


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
     <div class="topnav" id="myTopnav">
  <a href="LOGIN1.aspx" class="active">login</a>
  <a href="REGISTER1.aspx">Registration</a>
  <a href="MANAGEMODULES.aspx">Manage Modules</a>
  <a href="SEARCH.aspx">Search modules</a>
  <a href="Reminder.aspx">Reminder</a>
  <a href="javascript:void(0);" class="icon" onclick="myFunction()">
    <i class="fa fa-bars"></i>
  </a>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Calendar ID="reminderCal" runat="server"></asp:Calendar>
        </div>
    
    <asp:Label ID="Label1" runat="server" Text="REMINDER"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="ModuleC">
        <Columns>
            <asp:BoundField DataField="ModuleC" HeaderText="ModuleC" ReadOnly="True" SortExpression="ModuleC" />
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
        </Columns>
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [reminder]"></asp:SqlDataSource>
   
    <br />
    <br />
    <asp:TextBox ID="Rtxt" runat="server" Height="16px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button15" runat="server" Text="Button" OnClick="Button15_Click" />
    </form>
</body>
</html>
