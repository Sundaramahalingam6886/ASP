﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="First.aspx.cs" Inherits="Scheduler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="icon" href="a.jpg"/>
    <title>Schedule</title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    <h3>First Week</h3>
        <br />
        <asp:GridView ID="GridView2" runat="server" 
             CellPadding="4" 
            ForeColor="#333333" GridLines="None" Height="185px" Width="251px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Next" onclick="Button1_Click" />
        <br />
    
    </div>
    </form>
    </body>
</html>
