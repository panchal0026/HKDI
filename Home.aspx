<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true"
    CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="Scripts/jquery-1.9.1.js" type="text/javascript"></script>
    <script src="jquery.bxslider.js" type="text/javascript"></script>
    <link href="jquery.bxslider.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
        $(document).ready(function () {
            $('.bxslider').bxSlider({
                mode: 'fade',
                captions: true,
                auto: true
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="float:left;width:70%;">
        <asp:Repeater runat="server" ID="rpEvent">
            <HeaderTemplate>
                <ul class="bxslider">
            </HeaderTemplate>
            <ItemTemplate>
            <asp:HyperLink NavigateUrl='<%#"EventDetail.aspx?id="+ Eval("Event_ID") %>' runat="server">
             <li><img src= '<%#"images/" + Eval("Event_Image") %>'  title='<%#Eval("Event_Title") %>'/></li>
            </asp:HyperLink>
              <%--  <tr style="background-color: #EBEFF0">
                    <td>
                        <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; width: 500px;">
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
                            <//tr>
                            <tr>
                                <td>
                                    Date:
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Font-Bold="true" Text='<%#Eval("Event_Date") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    image:
                                </td>
                                <td>
                                    <img src='<%#"images/" + Eval("Event_Image") %>' />
                                </td>
                            </tr>
                        </table>
                     </td>
                 </tr>
                                  --%>              
            </ItemTemplate>
            <FooterTemplate>
            </ul>
            </FooterTemplate>
        </asp:Repeater>
    </div>


    <div style="width:30%; margin-left:85%;">
        <marquee id="ml" style="text-align: center" direction="up" width="195" height="170"
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
