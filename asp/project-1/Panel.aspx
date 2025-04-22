<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="project_1.Panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Panel1" runat="server" Text="Panel1" OnClick="PanelClick1"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Panel2" runat="server" Text="Panel2" OnClick="Panel2_Click" />
        </div>
        <asp:Panel ID="PanelContainer" runat="server" BackColor="#FFFFCC" BorderColor="#660033" BorderStyle="Solid" Height="100px" Visible="False" Width="100%" style="padding:2rem;">
            <asp:TextBox ID="AmstrongInput" runat="server" TextMode="Number" placeholder="Enter a number"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CalcAmstrongButton" runat="server" Text="Amstrong" OnClick="CalcAmstrongButton_Click" />
            <br />
            <asp:Label ID="AmstrongResult" runat="server"></asp:Label>
        </asp:Panel>
        <p>
            &nbsp;</p>
        <asp:Panel ID="Panel3" runat="server" BackColor="Lime" BorderColor="Black" BorderStyle="Solid" Height="100px" Visible="False" Width="100%" style="padding:2rem;">
            <asp:TextBox ID="LowerLimit" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="UpperLimit" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="AmstrongRangeButton" runat="server" OnClick="AmstrongRangeButton_Click" Text="Find Numbers" />
            <br />
            &nbsp;&nbsp;
            <asp:Label ID="AmstrongRange" runat="server"></asp:Label>
            <br />
        </asp:Panel>
    </form>
</body>
</html>
