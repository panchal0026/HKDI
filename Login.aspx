<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <%-- <meta charset="UTF-8">--%>
  
</head>
<body>
    

    <%--<form id="form1" runat="server">--%>
    <div style="margin-top: 3.5%">
        <center>
            <h1>
                <b style="font-family: 'Bodoni MT Black'; font-size: x-large; font-weight: 100; font-style: normal;
                        color:#50A4A2;">HARE KRISHNA DIAMOND INSTITUTE</b>
            </h1>
        </center>
        </div>
        <br />
        <br />
        <hr />
         <div class="wrapper">
	<div class="container">
		<h1>Welcome</h1>
        <form class="form" runat="server" id="form1" >
			<asp:TextBox runat="server" ID="txtUname" placeholder="Username"></asp:TextBox>
			<asp:TextBox runat ="server" ID ="txtPassword" TextMode="Password" placeholder="Password"></asp:TextBox>
			<asp:Button runat="server" ID="btnLogin" Text="Log In" 
                            onclick="btnLogin_Click" />
		</form>
		</div>
        <ul class="bg-bubbles">
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
	</ul>
</div>
      
        <%--<center>
            <table>
                <tr>
                    <td>
                        UserName:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtUname"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>
                        <asp:TextBox runat ="server" ID ="txtPassword" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button runat="server" ID="btnLogin" Text="Log In" 
                            onclick="btnLogin_Click" />
                    </td>
                </tr>
            </table>
        </center>--%>
   <%-- </div>
    <asp:Label runat="server" ID="lblVisit"></asp:Label>--%>
    <%--</form>--%>
     <script src="js/jquery-1.3.2.min.js" type="text/javascript"></script>

        <script src="js/index (2).js" type="text/javascript"></script>

</body>
</html>
