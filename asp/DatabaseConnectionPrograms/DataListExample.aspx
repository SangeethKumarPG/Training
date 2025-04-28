<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataListExample.aspx.cs" Inherits="DatabaseConnectionPrograms.DataListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!--<style>
        table,th,td {
            border: 1px solid black;
            border-collapse:collapse;
        }
        tr{
            width:25rem;
        }
        td, th{
            padding:2rem 0.5rem;
            
        }
    </style>-->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Designation</th>
                            <th>Salary</th>
                            <th>Dept ID</th>
                            <th>Update</th>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="IdLabel" Text='<%#Eval("Id")%>'></asp:Label>
                            </td>
                                                        <td>
                                <asp:Label runat="server" ID="NameLabel" Text='<%#Eval("Name")%>'></asp:Label>
                            </td>
                                                        <td>
                                <asp:Label runat="server" ID="DesignationLabel" Text='<%#Eval("Designation")%>'></asp:Label>
                            </td>
                                                        <td>
                                <asp:Label runat="server" ID="SalaryLabel" Text='<%#Eval("Salary")%>'></asp:Label>
                            </td>
                                                        <td>
                                <asp:Label runat="server" ID="DeptLabel" Text='<%#Eval("Dept")%>'></asp:Label>
                            </td>
                            <td>
                                <a href="EmployeeUpdate.aspx?id=<%#DataBinder.Eval(Container.DataItem,"Id") %>">Update</a>
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Remove" CommandName="Remove" CommandArgument='<% #Eval("id") %>' OnCommand="Button2_Command" />
                      
                            </td>

                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <br />
        </div>
    </form>
</body>
</html>
