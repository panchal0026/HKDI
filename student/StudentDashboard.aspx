<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="StudentDashboard.aspx.cs" Inherits="student_StudentDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<table style="width: 30%; height: 300px; font-family: 'Franklin Gothic Heavy'; font-size: large; font-weight: lighter; font-style: normal; font-variant: normal; color: #4D4D4D;" bgcolor="#ACDFD3" frame="vsides">
    <tr>
        <td>
            Admission Year Id:
        </td>
        <td>
            <asp:Label runat="server" ID="lblAdmission_Year_ID"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Student ID:
        </td>
        <td>
            <asp:Label runat="server" ID="lblStudent_ID"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Student Name:
        </td>
        <td>
            <asp:Label runat="server" ID="lblStudent_Name"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Contact No:
        </td>
        <td>
            <asp:Label runat="server" ID="lblContact_No"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Email:
        </td>
        <td>
            <asp:Label runat="server" ID="lblEmail"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Password:
        </td>
        <td>
            <asp:Label runat="server" ID="lblPassword"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Class_ID:
        </td>
        <td>
            <asp:Label runat="server" ID="lblClass_ID"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Current Subject Id:
        </td>
        <td>
            <asp:Label runat="server" ID="lblCurrent_Subject_ID"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Faculty:
        </td>
        <td>
            <asp:Label runat="server" ID="lblFaculty"></asp:Label>
        </td>
    </tr>
</table>
</center>
</asp:Content>

