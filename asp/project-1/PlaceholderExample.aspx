<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceholderExample.aspx.cs" Inherits="project_1.PlaceholderExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <br />
            <asp:Button ID="BTNAddControl" runat="server" OnClick="BTNAddControl_Click" style="margin-right: 38px" Text="AddControl" />
            <asp:Button ID="BTNRemoveControl" runat="server" OnClick="BTNRemoveControl_Click" style="margin-left: 23px" Text="Remove Control" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
