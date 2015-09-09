<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="EventList.aspx.cs" Inherits="admin_EventList" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/ui-lightness/jquery-ui-1.10.4.custom.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <link href="../Styles/PopUp.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../Scripts/PopUpScript.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            $("#txtEventDate").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h2>
            EVENTS
        </h2>
    </center>
    <center>
        <asp:Panel runat="server" ID="pnlform" Visible="false">
            <table>
                <tr>
                    <td>
                        Event Title:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtEventTitle"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Event Description:
                    </td>
                    <td>
                        <CKEditor:CKEditorControl ID="txtEventDescription" runat="server"></CKEditor:CKEditorControl>
                    </td>
                </tr>
                <tr>
                    <td>
                        Event Date:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtEventDate" ClientIDMode="Static">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Event Image:
                    </td>
                    <td>
                        <asp:FileUpload runat="server" ID="fu1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Organized by:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtOrganizedBy"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="btnSaveEvent" Text="Save" Visible="false" />
                        <asp:Button runat="server" ID="save" Text="Save" OnClick="save_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnldata">
            <asp:GridView runat="server" ID="gvEvent" AutoGenerateColumns="false" OnRowCommand="Event_Grid_RowCommand"
                AlternatingRowStyle-BackColor="#A9DED2" AlternatingRowStyle-BorderStyle="none"
                AllowPaging="True" AllowSorting="True" BorderColor="White" CellPadding="2" CellSpacing="5"
                Width="1000px" HeaderStyle-BackColor="#A9DED2" HeaderStyle-BorderColor="#50A4A2"
                HeaderStyle-BorderStyle="Inset" Font-Bold="True">
                <Columns>
                    <asp:TemplateField HeaderText="Event Title">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Event_Title") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Event Description">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("Event_Description") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Event Date">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Event_Date") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Organized by">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("Organized_by") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Add Images">
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" Text="Add Images" CommandName="AddImage"
                                CommandArgument='<%#Eval("Event_id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server" Text="Add Event" ID="btnaddevent" OnClick="btnaddevent_Click" />
            <%--<asp:Repeater runat="server" ID="rpEvent">
                <HeaderTemplate>
                    <table style="border: 1px solid black; width: 600px">
                        <tr>
                            <td>
                                <b>Events</b>
                            </td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr style="background-color: #EBEFF0">
                        <td>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; width: 500px">
                                <tr>
                                    <td>
                                        Event Title
                                    </td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("Event_Title") %>' Font-Bold="true" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Event Description
                                    </td>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("Event_Description") %>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Organized by:
                                    </td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Font-Bold="true" Text='<%#Eval("Organized_by") %>' />
                                    </td>
                                    <tr>
                                        <td>
                                            Date:
                                        </td>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Font-Bold="true" Text='<%#Eval("Event_Date") %>' />
                                        </td>
                                    </tr>
                                    <%-- <tr>
                                    <td>
                                       &nbsp;
                                    </td>
                                    <td>
                                        image:
                                    </td>
                                    <td>
                                        <img src='<%#Eval("Event_Image") %>' />
                                    </td>
                                </tr>--%>
            <%-- </table>
                </ItemTemplate>
                
                   
                
            </asp:Repeater>--%>
        </asp:Panel>
    </center>
    <div class="modal">
        <div class="modal-header">
            <h3>
                Add Images <a class="close-modal" href="#">&times;</a></h3>
        </div>
        <div class="modal-body">
            <asp:HiddenField runat="server" ID="hfImgID" />
            <center>
                <table>
                    <tr>
                        <td>
                            Add image:
                        </td>
                        <td>
                            <asp:FileUpload runat="server" ID="fileupload" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            IsActive:
                        </td>
                        <td>
                            <asp:CheckBox runat="server" ID="cb_IsActive" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button runat="server" ID="btnaddimage" Text="Add Image" OnClick="btnaddimage_Click" />
                        </td>
                    </tr>
                </table>
            </center>
        </div>
        <div class="modal-footer">
            <asp:Button ID="btn_close" runat="server" Text="OK" CssClass="modalOK close-modal" />
        </div>
    </div>
    <%--<div class="modal-backdrop"></div>--%>
</asp:Content>
