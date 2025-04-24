<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxListExample.aspx.cs" Inherits="project_1.CheckBoxListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Panel ID="Panel1" runat="server">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                </asp:CheckBoxList>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
