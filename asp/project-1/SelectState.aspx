<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectState.aspx.cs" Inherits="project_1.SelectState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;&nbsp;&nbsp; Select State:<br />
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDLState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLState_SelectedIndexChanged">
                <asp:ListItem Value="-1">Select State</asp:ListItem>
                <asp:ListItem>Kerala</asp:ListItem>
                <asp:ListItem>Tamilnadu</asp:ListItem>
                <asp:ListItem>Karnataka</asp:ListItem>
            </asp:DropDownList>
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp; Select District<br />
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDLDistrict" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
        </div>
    </form>
</body>
</html>
