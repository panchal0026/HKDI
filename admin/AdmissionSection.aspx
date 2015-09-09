<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AdmissionSection.aspx.cs" Inherits="admin_AdmissionSection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel runat="server" ID="pnlgrid">
    <asp:Button runat = "server"  Text="Start New" ID="btnAddAdmission" OnClick="btnAddAdmission_Click"/>
    <asp:GridView runat="server" ID="grid_AdmissionYear" 
        AutoGenerateColumns="false" onrowcommand="grid_AdmissionYear_RowCommand" >
    <Columns>
        <asp:TemplateField HeaderText ="Year">
            <ItemTemplate>
                <asp:Label runat="server" ID="lblYear" Text='<%#Eval("Year") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText ="Course Name">
            <ItemTemplate>
                <asp:Label runat="server" ID="lblCourse" Text='<%#Eval("Course_Name") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText ="Add Class">
            <ItemTemplate>
                <asp:HyperLink runat="server" ID="hlAddClass" NavigateUrl='<%#"ClassManagement.aspx?Admission_Year_ID="+ Eval("Admission_Year_ID") + "&year=" + Eval("Year") %>' Text="Add Class"></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton runat="server" CommandName ="DeleteYear" CommandArgument ='<%#Eval("Admission_Year_ID") %>' Text="Delete"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    </asp:GridView>
</asp:Panel>

<asp:Panel runat="server" ID="pnlform" Visible="false">
    <center>
        <table>
            <tr>
                <td>
                    Select Year:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtYear"></asp:TextBox>
                </td> 
            </tr>
            <tr>
                <td>
                    Select Course:
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="drpCourse"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button runat="server" ID="btnSaveYear" Text="Create Admission" OnClick="btnSaveYear_Click" />
                </td>
            </tr>
        </table>
    </center>
</asp:Panel>
</asp:Content>

