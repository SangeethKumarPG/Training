<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HyperlinkExample.aspx.cs" Inherits="project_1.HyperlinkExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="HyperlinkDestination.aspx">Hyper Link</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
            <br />
        </div>
    </form>
</body>
</html>
