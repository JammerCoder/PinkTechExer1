<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="School1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="900px" border="1">
                <tr>
                    <td>
                        <asp:Label ID="lblFirstName" runat="server" Text="First Name" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" ToolTip="Enter First Name" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLastName" runat="server" Text="Last Name" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server" ToolTip="Enter Last Name"/>
                    </td>
                </tr>                            
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnCombine" runat="server" Text="Combine" OnClick="btnCombine_Click" ToolTip="ClickMe!"/><asp:Label ID="lblResult" runat="server" Text="" />
                    </td>
                </tr>            
            </table>            
            
        </div>
    </form>
</body>
</html>
