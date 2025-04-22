<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BMI.aspx.cs" Inherits="project_1.BMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Weight" runat="server" placeholder="weight in kg"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Height" runat="server" placeholder="height in cm"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Result" runat="server" placeholder="BMI" Enabled="false"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
