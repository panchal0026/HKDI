<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="JumpRequest.aspx.cs" Inherits="admin_JumpRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <asp:Panel runat="server" ID="pnldata">
        <asp:GridView runat="server" ID="gvJumpNotification" 
            AutoGenerateColumns="false"  >
            <Columns>
                <asp:TemplateField HeaderText="From Date">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%#Eval("Reason") %>'></asp:Label>
                        <asp:HiddenField runat="server" ID="hfStudentID" Value ='<%#Eval("Student_ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Student_ID">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Student_ID") %>'></asp:Label>
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

