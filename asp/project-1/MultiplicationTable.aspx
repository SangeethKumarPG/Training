<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiplicationTable.aspx.cs" Inherits="project_1.MultiplicationTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="InputNumber" runat="server" placeholder="Enter a number: "></asp:TextBox>
            <br />
            <asp:Button ID="DisplayTable" runat="server" OnClick="DisplayTable_Click" Text="Calculate" />
&nbsp;<br />
            <br />
            <br />
            <br />
            <asp:Label ID="Result" runat="server"></asp:Label>
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
