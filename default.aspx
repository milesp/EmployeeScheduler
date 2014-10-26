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
              <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
                    <ItemTemplate>
                        <tr>
                             <td>
                                  <asp:TextBox runat="server" ID="TextBox1"
                                       Text='<%# Eval("Day") %>' />
                             </td>
                             <td>
                                  <asp:TextBox runat="server" ID="TextBox2"
                                       Text='<%# Eval("ShiftNum") %>' />
                             </td>
                             <td>
                               <asp:TextBox runat="server" ID="TextBox3"
                                       Text='<%# Eval("EmployeeTotal") %>' />
                             </td>
                             <td>
                               <asp:TextBox runat="server" ID="TextBox4"
                                       Text='<%# Eval("ExpAvg") %>' />
                             </td>
                              <br><br/>


                        </tr>
                   </ItemTemplate>
              </asp:Repeater>
              <br />

              <br />

         </div>
         <div>
  
  
</div>
  </form>
</body>
</html>
