<%@ Page Title="" Language="C#" MasterPageFile="~/FacultyMasterPage.master" AutoEventWireup="true"
    CodeFile="StudyMaterial.aspx.cs" Inherits="StudyMaterial" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/ui-lightness/jquery-ui-1.10.4.custom.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <link href="../Styles/PopUp.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../Scripts/PopUpScript.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            $("#txtMaterialUploadDate").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel runat="server" ID="pnlform" Visible="false">
        <center>
            <h2>
                Upload Material
            </h2>
            <table>
                <tr>
                    <td>
                        Select Course:
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddCourse" Width="200px">
                            <asp:ListItem Text="" Value="0"></asp:ListItem>
                            <asp:ListItem Text="One Year" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Two Year" Value="2"></asp:ListItem>
                        </asp:DropDownList>
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
                        Faculty:
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblFacultyName"></asp:Label>
                        <asp:HiddenField runat="server" ID="hfFacultyID" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Title:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTitle"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Description:
                    </td>
                    <td>
                        <CKEditor:CKEditorControl ID="txtMaterialDescription" runat="server"></CKEditor:CKEditorControl>
                    </td>
                </tr>
                <%--     <tr>
                    <td>
                        Date Uploaded:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtMaterialUploadDate" ClientIDMode="Static">
                        </asp:TextBox>
                    </td>
                </tr>
                --%>
                <tr>
                <td>
                    Document:
                </td>
                    <td>
                        <asp:FileUpload runat="server" ID="FileUpload" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" ID="btnSubmitStudyMaterial" Text="Submit" OnClick="btnSubmitStudyMaterial_Click" /><%--OnClick="btnSubmitStudyMaterial_Click" --%>
                    </td>
                </tr>
            </table>
        </center>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnldata">
    <asp:GridView runat="server" ID="gvStudyMaterial" AutoGenerateColumns="false" AlternatingRowStyle-BackColor="#A9DED2"
        AlternatingRowStyle-BorderStyle="none" AllowPaging="True" AllowSorting="True"
        BorderColor="White" CellPadding="2" CellSpacing="5" Width="1000px" HeaderStyle-BackColor="#A9DED2"
        HeaderStyle-BorderColor="#50A4A2" HeaderStyle-BorderStyle="Inset" Font-Bold="True">
        <Columns>
            <asp:TemplateField HeaderText="Course ID">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Course_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Subject ID">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Subject_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           <asp:TemplateField HeaderText="Upladed date">
            <ItemTemplate>
                <asp:Label runat="server" Text='<%#Eval("Upload_Date") %>'></asp:Label>
            </ItemTemplate>
           </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" Text="Add Material" ID="btnAddMaterial" OnClick="btnAddMaterial_Click" />
    </asp:Panel>
</asp:Content>
