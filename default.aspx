<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="EmployeeScheduler._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
               <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
               <asp:TextBox ID="shiftsPerDay" runat="server"></asp:TextBox>
               <asp:TextBox ID="numOfDays" runat="server"></asp:TextBox>
               <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
               </asp:Repeater>
    </div>
    </form>
</body>
</html>
