<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="SearchRecord.SearchR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 800px;
        }
    </style>
</head>
<body style="height: 264px">
    <form id="form1" runat="server">
        <div>
           <table style="margin:auto;" class="auto-style1">
               <tr>
                   <td>
                       <asp:GridView ID="GridView1" runat="server" Height="260px" Width="797px">
                           </asp:GridView>
                   </td>
               </tr>
           </table>
            
            
            
            
        </div>
    </form>
</body>
</html>
