<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <center>
                <asp:Panel runat="server" ID="pnlform" Visible = "false">
                    <table>
                        <tr>
                            <td>
                                Testval
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtt1"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Testval2
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtt2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <asp:Button runat="server" ID="btnAdd" Text="Add" onclick="btnAdd_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
           
           <asp:Panel runat="server" ID="pnlData">
                <asp:Button runat="server" ID="btnNewEntry" OnClick = "btnNewEntry_Click" Text = "AddNew" />
                <asp:GridView runat="server" ID="List_Grid">
                </asp:GridView>
           </asp:Panel>
           </center>
    </div>
    </form>
</body>
</html>
