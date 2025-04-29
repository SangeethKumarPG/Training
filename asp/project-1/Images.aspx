<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Images.aspx.cs" Inherits="project_1.Images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Image ID="Image1" runat="server" Height="370px" ImageUrl="~/images/s2.jpg" Width="636px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="190px" ImageUrl="~/images/s2.jpg" OnClick="ImageButton1_Click" style="margin-right: 0px" Width="449px" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
