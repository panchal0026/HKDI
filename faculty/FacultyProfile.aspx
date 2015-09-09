<%@ Page Title="" Language="C#" MasterPageFile="~/FacultyMasterPage.master" AutoEventWireup="true"
    CodeFile="FacultyProfile.aspx.cs" Inherits="faculty_FacultyProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Styles/styles.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin-top: 2%; margin-left: 5%; width: 20%; height: 400px; background-color: #E7E7E8;">
        <div style="background-color: #E7E7E8; height: 40%; width: 100%; background-image: url('../images/profile.jpg');">
            <asp:DataList runat="server" ID="dl1">
                <ItemTemplate>
                    <div>
                        <asp:Image class="img-circle" ID="img1" runat="server" ImageUrl='<%#Eval("Faculty_Image") %>'>
                        </asp:Image>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <br />
            <center>
                <asp:DataList runat="server" ID="dlName">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Faculty_name") %>' Font-Bold="True" Font-Italic="True"
                            Font-Size="Larger"></asp:Label>
                    </ItemTemplate>
                </asp:DataList>
            </center>
            <center>
                <br />
                <br />
                <asp:DataList runat="server" ID="dl2" Style="margin-top: 5%; color: ;">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("Faculty_AreaOfInterest") %>'
                            Font-Italic="True" Font-Size="Smaller"></asp:Label>
                    </ItemTemplate>
                </asp:DataList>
            </center>
        </div>
        <div style="width: 100%; height: 40%; margin-top: 100%; background-color: #D9D9D9;">
            <center>
                <br />
                <br />
                <asp:DataList runat="server" ID="dlInfo">
                    <ItemTemplate>
                        <table style="font-family: 'Lucida Handwriting'; font-size: smaller; font-weight: normal;
                            font-style: italic; color: #000000">
                            <tr>
                                <td>
                                    Lives in
                                    <asp:Label runat="server" Text='<%#Eval("Faculty_address") %>' Font-Bold="True"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Can contact on
                                    <asp:Label runat="server" Text='<%#Eval("Faculty_email_id") %>' Font-Bold="True"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    has worked in
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("Faculty_Experience") %>' Font-Bold="True"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </center>
        </div>
    </div>
    <div style="border: thin solid #000000; width: 600px; height: 1000px; background-color: #FFFFFF;
        margin-left: 30%; margin-top: -30%;">
        <div style="background-color: #D8D8D8; width: 100%; height: 5%">
        </div>
        <asp:HiddenField runat="server" ID="hfFacultyID" />
        <asp:Repeater runat="server" ID="rpMaterial">
            <ItemTemplate>
                <style type="text/css">
                    .tg
                    {
                        border-collapse: collapse;
                        border-spacing: 0;
                    }
                    .tg td
                    {
                        font-family: Arial, sans-serif;
                        font-size: 14px;
                        padding: 10px 5px;
                        border-style: solid;
                        border-width: 1px;
                        overflow: hidden;
                        word-break: normal;
                    }
                    .tg th
                    {
                        font-family: Arial, sans-serif;
                        font-size: 14px;
                        font-weight: normal;
                        padding: 10px 5px;
                        border-style: solid;
                        border-width: 1px;
                        overflow: hidden;
                        word-break: normal;
                    }
                    .tg .tg-0ord
                    {
                        
                    }
                </style>
                <table class="tg" width="100%">
                    <tr>
                        <th class="tg-0ord">
                            <asp:Label runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                        </th>
                        <th class="tg-031e">
                            <asp:Label runat="server" Text='<%#Eval("Upload_Date") %>'></asp:Label>
                        </th>
                    </tr>
                    <tr>
                        <td class="tg-031e" colspan="2" align="center">
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("Description") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tg-031e" colspan="2" align="right">
                            <asp:Label ID="Label6" runat="server" Text='<%#Eval("File_Path") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div style="width: 200px; height: 500px; background-color: white; margin-left: 80%;
        margin-top: -75%;">
        <marquee id="ml" style="text-align: center" direction="up" width="195" height="250"
            scrolldelay="2" scrollamount="1" onmouseover="ml.stop();" onmouseout="ml.start();">
                                <asp:Repeater id="rptNews" runat="server">
                                <ItemTemplate>
                                <br />                            
                             
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"NewsDetail.aspx?id="+ Eval("News_ID") %>' style="color:#800000;">
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("News_Title") %>'></asp:Label>
                                   
                                    </asp:HyperLink><br />
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("News_Description") %>'> </asp:Label>
                            </ItemTemplate>
                            </asp:Repeater></marquee>
    </div>
</asp:Content>
