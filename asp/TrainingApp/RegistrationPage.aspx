<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="TrainingApp.RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <br />
            User Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            User Name :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Position :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="-1">Select a position</asp:ListItem>
                <asp:ListItem Value="0">Trainee</asp:ListItem>
                <asp:ListItem Value="1">Trainer</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Subjects Taking:" Visible="False"></asp:Label>
&nbsp;<asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Visible="False">
            </asp:CheckBoxList>
            <br />
            Password :&nbsp;&nbsp;
            <asp:TextBox ID="TxtBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
