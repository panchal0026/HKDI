<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Hme.aspx.cs" Inherits="Hme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="HomeCss/css/style.css" />
    <link rel="Stylesheet" href="sliderCss/style.css" />
    <script type="text/javascript" src="HomeCss/js/jquery-1.10.2.min.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header id="header">
<div class="content">
<div id="logo"><a href=""> Hare Krishna Exports Pvt.Ltd </a></div>

<nav id="nav">
	<ul>
		<li><a href="#slide1" class="active" title="Next Section" >Home</a></li>
		<li><a href="#slide2" title="Next Section">About</a></li>
		<li><a href="#slide3" title="Next Section">Academics</a></li>
		<li><a  href="#slide4" title="Next Section">Admission Aid</a></li>
		
	</ul>
</nav>
</div>
</header>
        <div id="slide1">
            <div class="content">
                <h1>
                    Hare Krishna Diamond Institute
                </h1>
                <div id="divider">
                </div>
                <h3>
                    Faith is in the name
                </h3>
            </div>
        </div>
        <div id="slide2">
            <div class="content">
                <div class="quotes_container">
                    <%--<div>
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
                    padding: 10px 20px;
                    border-style: solid;
                    border-width: 1px;
                    overflow: hidden;
                    word-break: normal;
                    border-color: #808000;
                    border-width:15px;
                }
                .tg th
                {
                    font-family: Arial, sans-serif;
                    font-size: 14px;
                    font-weight: normal;
                    padding: 10px 20px;
                    border-style: solid;
                    border-width: 1px;
                    overflow: hidden;
                    word-break: normal;
                    border-color: #808000;
                    border-width:15px;
                }
            </style>
            <table class="tg" style="padding: 5%; border-style: groove; border-color: #808000; width: 90%; height: 400px; margin-top: -8%; margin-left:-15%; border-top-width: thick; list-style-type: disc; border-collapse: collapse; border-spacing: 5%;">
                <tr>
                    <th class="tg-031e">
                    </th>
                    <th class="tg-031e">
                    </th>
                    <th class="tg-031e">
                    </th>
                    <th class="tg-031e">
                    </th>
                </tr>
                <tr>
                    <td class="tg-031e">
                    </td>
                    <td class="tg-031e">
                    </td>
                    <td class="tg-031e">
                    </td>
                    <td class="tg-031e">
                    </td>
                </tr>
            </table>
        </div>--%>
                    <%--   <div style="width: 30%; margin-left: 850px; height: 300px; margin-top: -20%;">
                        <marquee id="ml" style="text-align: center" direction="up" width="195" height="200"
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
                    </div>--%>
                    
                </div>
            </div>
        </div>
        <div id="slide3">
            <div class="content">
                <div class="quotes_container">
                </div>
            </div>
        </div>
        <div id="slide4">
            <div class="content">
                <div class="quotes_container">
                </div>
            </div>
        </div>
        <div id="slide5">
            <div class="content">
                <div class="quotes_container">
                </div>
            </div>
        </div>
        <div id="slide6">
            <div class="content">
                <div class="quotes_container">
                    <img src="images/2.jpg" style=" height:300px; width:1340px; margin-top:40%; margin-left:-34%; " />
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
