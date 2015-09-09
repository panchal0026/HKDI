<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true"
    CodeFile="AcademicRecords.aspx.cs" Inherits="student_AcademicRecords" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="../Styles/jquery-ui.css" type="text/css" />
    <script type="text/javascript" src="../Scripts/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <%--<script type="text/javascript" src="../bootstrap-3.3.5-dist/js/bootstrap.min.js"></script>--%>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#tabs").tabs();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--  <div id="tabs" role="tabpanel">
    <ul class="nav nav-tabs" role="tablist">
        <li class="active">
            <a href="#tab1" aria-controls="tab1" role="tab1" data-toggle="tab">
                tab 1
            </a>
        </li>
        <li>
           <a href="#tab2" aria-controls="tab2" role="tab2" data-toggle="tab">
           tab 2
        </li>
    </ul>
    <div class="tab-content">
        <div role="tabpanel" class="tab-pane active" id="tab1" >
            
        </div>
        <div role="tabpanel" class="tab-pane" id="tab2" >
            
        </div>
    </div>
</div>--%>
    <%--    <div class="panel panel-default" style="width: 500px; padding: 10px; margin: 10px">
        <div id="Tabs" role="tabpanel">
            <ul class="nav nav-tabs" role="tablist">
                <li class="active"><a href="#personal" aria-controls="personal" role="tab" data-toggle="tab">
                    Student's Attendance</a></li>
                <li><a href="#employment" aria-controls="employment" role="tab" data-toggle="tab">Academice
                    Record</a></li>
            </ul>
            <div class="tab-content" style="padding-top: 20px">
                <div role="tabpanel" class="tab-pane" id="personal">
                    <div>--%>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">Attendance</a></li>
            <li><a href="#tabs-2">Marks</a></li>
            
        </ul>
        <div id="tabs-1">
            <asp:Panel runat="server" ID="pnlAttendance">
        <center>
            <table style="width: 30%; height: 300px; font-family: 'Franklin Gothic Heavy'; font-size: large;
                font-weight: lighter; font-style: normal; font-variant: normal; color: #4D4D4D;"
                bgcolor="#ACDFD3" frame="vsides">
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
                        Lecture conducted:
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblLectureConducted"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Absent:
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblAbsent"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Present:
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblPresent"></asp:Label>
                    </td>
                </tr>
            </table>
        </center>
    </asp:Panel>
        </div>
        <div id="tabs-2">
            <p>
                Blah some more.</p>
        </div>
        
    </div>
   
    <%--</div>
                </div>
                <div role="tabpanel" class="tab-pane" id="employment">
                    This is Marks Information Tab
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>
