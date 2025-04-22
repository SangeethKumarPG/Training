<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SumOfTwoNumbers.aspx.cs" Inherits="project_1.SumOfTwoNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h3 style="margin-left: 350px">Sum of two numbers</h3>
        <div>
            
        </div>
        <div style="margin-left: 280px">
            Number 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="FirstNumber" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <br />
            Number 2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SecondNumber" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="ADD" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Subtract" runat="server" OnClick="SubtractButton_Click" Text="SUB" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Multiply" runat="server" OnClick="MultiplyButton_Click" Text="MUL" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Divide" runat="server" OnClick="DivideButton_Click" Text="DIV" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Reset" runat="server" OnClick="ResetButton_Click" Text="Reset" BackColor="Red" ForeColor="White" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Sum" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
