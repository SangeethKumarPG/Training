<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MinorOrMajor.aspx.cs" Inherits="project_1.MinorOrMajor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex; align-items:center; justify-content:center;">
            <p>
                &nbsp;</p>
            <h3 style="margin-left: 0px">
                Minor or Major
            </h3>
            <p>
                &nbsp;</p>
            
        </div>
        <div style="margin-left: 280px">
            <asp:Label ID="Label1" runat="server" Text="Age"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Age" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CheckMinorOrMajor" runat="server" Text="Minor/Major" OnClick="CheckMinorOrMajor_Click" />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
