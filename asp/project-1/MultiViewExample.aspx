<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiViewExample.aspx.cs" Inherits="project_1.MultiViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />

            <asp:MultiView ID="MultiView1" runat="server">
                          <asp:View ID="View1" runat="server">
                              <br />
                              <br />
                              Go to View 2 :
                              <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                              <br />
            </asp:View>
                                <asp:View ID="View2" runat="server">
                    <br />
                    Go to view 3 :
                    <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
                    <br />
                </asp:View>
                                <asp:View ID="View3" runat="server">
                    <br />
                    <br />
                    Go to view 1 :
                    <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
                </asp:View>
            </asp:MultiView>
           
            <br />
            <br />
            <br />
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
