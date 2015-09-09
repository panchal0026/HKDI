<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true"
    CodeFile="RequestJump.aspx.cs" Inherits="student_RequestJump" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel runat="server" ID="pnlform" Visible="false">
        <center>
            <table>
                Give Reason To Get Jump
                <tr>
                    <td>
                        Reason:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtReason"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" ID="btnSaveReason" Text="Save Reason" OnClick="btnSaveReason_Click" />
                    </td>
                </tr>
            </table>
        </center>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnldata" Visible="true">
        <center>
            <asp:GridView runat="server" ID="gvJumpRequest" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Reason">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Reason") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Is_Approved">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Is_Approved") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Is_Rejected">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Is_Rejected") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server" ID="btnRequestNewJump" Text="Request New Jump" OnClick="btnRequestNewJump_Click" />
        </center>
    </asp:Panel>
    <asp:Panel ID="pnlNotification" runat="server" Visible = "false">
    You have already requested for the jump, Your Request is under review. please Contact Administrative Incharge.
    </asp:Panel>
</asp:Content>
