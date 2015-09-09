<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ClassManagement.aspx.cs" Inherits="admin_ClassManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel runat="server" ID="pnlGrid">
<asp:Button runat="server" ID="btnAddClass" Text ="Create NewClass" OnClick="btnAddClass_Click"/>
    <asp:GridView runat="server" ID="grid_Class" AutoGenerateColumns = "false">
        <Columns>
            <asp:TemplateField HeaderText ="ClassName">
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblClass_Name" Text='<%#Eval("Class_Name") %>'>
                    </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Panel>

<asp:Panel runat="server" ID="pnlForm" Visible="false">
    <center>
        <table>
            <tr>
                <td>
                    Year:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtYear" Enabled ="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Class Alias:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtClassName"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button runat="server" ID="btnCreateClass" OnClick="btnCreateClass_Click" Text="Create Class" />
                </td>
            </tr>
        </table>
    </center>
</asp:Panel>
</asp:Content>

