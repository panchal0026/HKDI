<%@ Page Title="" Language="C#" MasterPageFile="~/FacultyMasterPage.master" AutoEventWireup="true"
    CodeFile="Attendance.aspx.cs" Inherits="Attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/ui-lightness/jquery-ui-1.10.4.custom.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            $("#txtAttendanceDate").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h2>
            ATTENDANCE
        </h2>
    </center>
    <table>
        <tr>
            <td>
                Select Course:
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddCourse" Width="200px" AutoPostBack="true"
                    OnSelectedIndexChanged="ddCourse_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Date:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtAttendanceDate" ClientIDMode="Static">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Select Subject:
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddSubject" Width="200px">
                    <asp:ListItem Text="" Value="0"></asp:ListItem>
                    <asp:ListItem Text="BLOCKING" Value="1"></asp:ListItem>
                    <asp:ListItem Text="BRUTING" Value="2"></asp:ListItem>
                    <asp:ListItem Text="FANCY CUT" Value="3"></asp:ListItem>
                    <asp:ListItem Text="ISDG" Value="4"></asp:ListItem>
                    <asp:ListItem Text="PLANNING" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Polishing Book" Value="6"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Session:
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddSession" Width="200px">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
         <tr>
                    <td>
                        <asp:Label runat="server" ID="lblClassID" Text="Class ID"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="drp_ClassID" AutoPostBack="true" OnSelectedIndexChanged="drp_ClassID_SelectedIndexChanged">
                            <%--AutoPostBack="true" OnSelectedIndexChanged="drp_ClassID_SelectedIndexChanged"--%>
                        </asp:DropDownList>
                    </td>
                </tr>
    </table>
    <asp:Panel runat="server" ID="pnlStudentList" Visible="false">
        <center>
            <asp:Repeater ID="rpt_Students" runat="server">
                <HeaderTemplate>
                    <table border="1" width="100%">
                        <tr>
                            <th>
                                Roll no.
                            </th>
                            <th>
                                Name
                            </th>
                            <th>
                                Attendance
                            </th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lblStud_ID" Text='<%#Eval("Student_ID") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text='<%#Eval("Student_Name") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:CheckBox runat="server" ID="cbAttendance" />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <asp:Button runat="server" ID="btnSaveAttendance" OnClick="btnSaveAttendance_Click"
                Text="Save Attendance" />
        </center>
    </asp:Panel>
</asp:Content>
