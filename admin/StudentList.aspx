<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="StudentList.aspx.cs" Inherits="StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/ui-lightness/jquery-ui-1.10.4.custom.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <link href="../Styles/PopUp.css" type="text/css" rel="Stylesheet" />
    <script src="../Scripts/PopUpScript.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel runat="server" ID="pnlform">
        <center>
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
                        <asp:Label runat="server" ID="lblClassID" Text="Class ID"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="drp_ClassID">
                            <%--AutoPostBack="true" OnSelectedIndexChanged="drp_ClassID_SelectedIndexChanged"--%>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Name:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtstudentname"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Contact no:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtstudentcontactno"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email id:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtstudentemailid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtstudentpassword" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr style="display:none;">
                    <td>
                        Current Subject:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCurrentSubject"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Assigned Faculty:
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="drpFaculty"></asp:DropDownList>
                    </td>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="btnsubmitstudent" runat="server" OnClick="btnsubmitstudent_Click"
                                Text="Submit" />
                        </td>
                    </tr>
                </tr>
            </table>
        </center>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnldata">
        <asp:GridView runat="server" ID="gvstudent" AutoGenerateColumns="false" OnRowCommand="gvstudent_RowCommand" AlternatingRowStyle-BackColor="#A9DED2" AlternatingRowStyle-BorderStyle="none" AllowPaging="True" AllowSorting="True" BorderColor="White" CellPadding="2" CellSpacing="5" Width="1000px" HeaderStyle-BackColor="#A9DED2" HeaderStyle-BorderColor="#50A4A2" HeaderStyle-BorderStyle="Inset" Font-Bold="True">
            <Columns>
                <asp:TemplateField HeaderText="Admission Year">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Admission_Year_ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Student_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Contact no">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Contact_No") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email id">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Class ID">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Class_ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Current Subject">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Current_Subject_ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Faculty">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Faculty_Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Change Password ">
                    <ItemTemplate>
                        <asp:Button runat="server" ID="btnChangePassword" Text="Change Password" CommandName="change_Password"
                            CommandArgument='<%#Eval("Email") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remove Student">
                    <ItemTemplate>
                        <asp:Button runat="server" ID="btnRemoveStudent" Text="Delete Student" CommandName="remove_Student"
                            CommandArgument='<%#Eval("Email") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <div class="modal">
        <div class="modal-header">
            <h3>
                Change Password<a class="close-modal" href="#">&times;</a></h3>
        </div>
        <div class="modal-body">
            <asp:HiddenField runat="server" ID="hfEmailID" />
            <center>
                <table>
                    <tr>
                        <td>
                            New Password:
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtNewPassword" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:Button runat="server" ID="btnNewPassword" Text="Change Password" OnClick="btnNewPassword_Click" />
                        </td>
                    </tr>
                </table>
            </center>
        </div>
        <div class="modal-footer">
            <asp:Button ID="btn_close" runat="server" Text="OK" CssClass="modalOK close-modal" />
        </div>
    </div>
    <div class="modal-backdrop">
    </div>
</asp:Content>
