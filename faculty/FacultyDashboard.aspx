<%@ Page Title="" Language="C#" MasterPageFile="~/FacultyMasterPage.master" AutoEventWireup="true" CodeFile="FacultyDashboard.aspx.cs" Inherits="FacultyDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <asp:GridView runat="server" ID="gv_StudentList" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Student ID">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Student_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Student_Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</center>
</asp:Content>

