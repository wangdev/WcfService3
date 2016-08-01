<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyServiceClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border:1px solid black" >
            <tr>
                <td>
                    <asp:Button ID="button1" runat="server" Text="Get public info" OnClick="button1_Click" Width="300px" />
                </td>
                <td>
                    <asp:Label ID="label1" runat="server" Font-Bold="true"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="button2" runat="server" Text="Get confid info" OnClick="button2_Click" Width="300px" />
                </td>
                <td>
                    <asp:Label ID="label2" runat="server" Font-Bold="true"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
