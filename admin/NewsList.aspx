<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="NewsList.aspx.cs" Inherits="admin_NewsList" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <link href="../css/ui-lightness/jquery-ui-1.10.4.custom.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-ui.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#txtNews_Date").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="pnlformNews" runat="server" Visible="false">
        <table>
            <tr>
                <td>
                   News Title
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtNews_Title"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    News Description
                </td>
                <td>
                 <CKEditor:CKEditorControl ID="txtNews_Description" runat="server"></CKEditor:CKEditorControl>
                    
                </td>
            </tr>
            <tr>
                <td>
                    News Date
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtNews_Date" ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnSubmitNews" Text="Submit" OnClick="btnSubmitNews_Click" />
                </td>
                <td>
                    <asp:Button runat="server" ID="btnCancelNews" Text="Cancel"  />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlgridNews">
        <asp:GridView runat="server" ID="gvNews" AutoGenerateColumns="false" AlternatingRowStyle-BackColor="#A9DED2" AlternatingRowStyle-BorderStyle="none" AllowPaging="True" AllowSorting="True" BorderColor="White" CellPadding="2" CellSpacing="5" Width="1000px" HeaderStyle-BackColor="#A9DED2" HeaderStyle-BorderColor="#50A4A2" HeaderStyle-BorderStyle="Inset" Font-Bold="True">
            <Columns>
                <asp:TemplateField HeaderText="News Description">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("News_Description") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="News Title">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("News_Title") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="News Date">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("News_Date") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button runat="server" ID="btnAddNews" Text="Add News" OnClick="btnAddNews_Click" />
    </asp:Panel>   
</asp:Content>

