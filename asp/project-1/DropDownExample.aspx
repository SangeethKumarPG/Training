<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownExample.aspx.cs" Inherits="project_1.DropDownExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Select Employee"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDLEmployee" runat="server" Height="19px" Width="233px">
                <asp:ListItem Value="-1">Select an employee</asp:ListItem>
                <asp:ListItem>Arjun</asp:ListItem>
                <asp:ListItem Value="431111">Rahul</asp:ListItem>
                <asp:ListItem Value="430127">Tinto</asp:ListItem>
            </asp:DropDownList>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEmpSelect" runat="server" OnClick="BtnEmpSelect_Click" Text="Select Employee" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="SelectResultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
