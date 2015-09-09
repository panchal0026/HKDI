<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="LeaveNotification.aspx.cs" Inherits="student_LeaveNotification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link href="../css/jquery-ui-1.10.4.custom.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            $("#txtFromLeave").datepicker();
        });
        $(document).ready(function () {
            $("#txtToLeave").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <asp:panel runat="server" id="pnlform" Visible="false">
        <table>
            <tr>
                <td>
                    From Date:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtFromLeave" ClientIDMode="Static" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                   To Date:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtToLeave" ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Comments:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtComments"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnSubmitLeaveRequest" Text="Submit" OnClick="btnSubmitLeaveRequest_Click" />
                </td>
            </tr>
        </table>
    </asp:panel>
    <asp:Panel runat="server" ID="pnldata" >
    <asp:GridView runat="server" ID="gvLeaveNotification" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="From Date">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("From_Date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="To Date">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("To_Date") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Comments">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Comments") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Is approved">
                <ItemTemplate>
                   <asp:Label ID="Label1" runat="server" Text='<%#Eval("IsApproved") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Is Rejected">
                <ItemTemplate>
                   <asp:Label ID="Label1" runat="server" Text='<%#Eval("IsRejected") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" Text="request new leave" ID="txtRequestNewLeave" OnClick="txtRequestNewLeave_Click" />
    </asp:Panel>
</center>
</asp:Content>

