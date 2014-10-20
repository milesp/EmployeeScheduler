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
    </div>
         <div>
              <br />
              <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
              </asp:Repeater>
              <br />
         </div>
         <asp:ObjectDataSource ID="ObjectDataSource1" SelectMethod="GetShifts" TypeName="ES.Model.Shift" runat="server"></asp:ObjectDataSource>
    </form>
</body>
</html>
