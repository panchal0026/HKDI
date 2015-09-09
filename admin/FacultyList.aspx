<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="FacultyList.aspx.cs" Inherits="admin_FacultyList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel runat="server" ID="pnlForm" Visible="false">
<center>
    <table style="font-family: 'Century Gothic'; font-size: medium; font-style: normal; width: 400px; height: 400px;">
        <tr>
            <td>
                Faculty name:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFacultyname"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Faculty email-id:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFacultyemailid"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Faculty password:
            </td>
            <td>
            <asp:TextBox runat="server" ID="txtFacultypassword" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Faculty contact no:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFacultycontactno" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Faculty address:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFacultyaddress"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Area Of Interest:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFacultyAreaOfInterest"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Experience:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFacultyExperience"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Image:
            </td>
            <td>
                <asp:FileUpload runat="server" ID="fileupload" />
            </td>
        </tr>
        <tr>
            <td>
                course id:
            </td>
            <td>
                <asp:TextBox runat="server" Id="txtFacultycourseid"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                batch no:
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFacultybatchno"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button runat="server" ID="btnsubmit" Text="Submit" 
                    OnClick="btnsubmit_Click" BackColor="white" />
                &nbsp;&nbsp;
                <asp:Button runat="server" Id="btncancel" Text="Cancel" 
                    OnClick="btncancel_Click" BackColor="white" />
            </td>
        </tr>
    </table>
</center>
</asp:Panel>

<asp:Panel runat="server" ID="pnlData">
    <center>
        <asp:GridView runat="server" ID="gvFaculty" AutoGenerateColumns="false" AlternatingRowStyle-BackColor="#CFE0CD" AlternatingRowStyle-BorderStyle="none" AllowPaging="True" AllowSorting="True" BorderColor="White" CellPadding="2" CellSpacing="5" Width="1000px" HeaderStyle-BackColor="#CFE0CD" HeaderStyle-BorderColor="#50A4A2" HeaderStyle-BorderStyle="Inset" Font-Bold="True" GridLines="Vertical">
            <Columns>
                <asp:TemplateField HeaderText="name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Faculty_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="email id">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%#Eval("Faculty_email_id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="contact no">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%#Eval("Faculty_contact_no") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="address">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%#Eval("Faculty_address") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="city">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%#Eval("Faculty_AreaOfInterest") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="state">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Faculty_Experience") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="pincode">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%#Eval("Faculty_Image") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="course id">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Faculty_course_id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="batch no">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Faculty_batch_no") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <asp:Button runat="server" ID="btnAddFaculty" Text="Add Faculty" OnClick="btnAddFaculty_Click" />
    </center>
</asp:Panel>
</asp:Content>

