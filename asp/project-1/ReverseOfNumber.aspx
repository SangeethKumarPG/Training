<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReverseOfNumber.aspx.cs" Inherits="project_1.ReverseOfNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="InputNumber" runat="server" placeholder="Enter a number"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Reverse" runat="server" Text="Reverse" OnClick="Reverse_Click" />
            <br />
            <br />
            <asp:TextBox ID="Result" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
