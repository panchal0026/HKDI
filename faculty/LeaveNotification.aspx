<%@ Page Title="" Language="C#" MasterPageFile="~/FacultyMasterPage.master" AutoEventWireup="true"
    CodeFile="LeaveNotification.aspx.cs" Inherits="faculty_LeaveNotification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel runat="server" ID="pnldata">
        <asp:GridView runat="server" ID="gvLeaveNotification" 
            AutoGenerateColumns="false" onrowcommand="gvLeaveNotification_RowCommand" >
            <Columns>
                <asp:TemplateField HeaderText="From Date">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("From_Date") %>'></asp:Label>
                        <asp:HiddenField runat="server" ID="hfLeaveID" Value ='<%#Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="To Date">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("To_Date") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Comments">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%#Eval("Comments") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Is approved">
                    <ItemTemplate>
                        <asp:CheckBox runat="server" ID="ckIsApproved" OnCheckedChanged ="ckIsApproved_CheckedChanged" AutoPostBack="true" />
                        <%-- <asp:Label ID="Label1" runat="server" Text='<%#Eval("IsApproved") %>'></asp:Label>--%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Is Rejected">
                    <ItemTemplate>
                        <asp:CheckBox runat="server" ID="ckIsRejected" OnCheckedChanged ="ckIsRejected_CheckedChanged" AutoPostBack="true"  />
                        <%-- <asp:Label ID="Label1" runat="server" Text='<%#Eval("IsRejected") %>'></asp:Label>--%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </asp:Panel>
</asp:Content>
