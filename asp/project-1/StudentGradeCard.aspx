<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentGradeCard.aspx.cs" Inherits="project_1.StudentGradeCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex; align-items:center; justify-content:center">
            <h3>Student GradeCard</h3>
        </div>
        <div>
            Name&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server" TextMode="SingleLine"></asp:TextBox>
            <br />
            <br />
            Physics&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Physics" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Chemistry&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Chemistry" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Biology&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Biology" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Maths&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Maths" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            English&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="English" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            <br />
            <br />
            <asp:Label ID="NameLabel" runat="server" Text="Name : "></asp:Label>
            <br />


            <asp:Label ID="Grade" Text="Grade:" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Total" Text="Total : " runat="server"></asp:Label>
            <br />
            <asp:Label ID="Percentage" Text="Percentage : " runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
