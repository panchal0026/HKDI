<%@ Page Language="C#" AutoEventWireup="true" CodeFile="logn.aspx.cs" Inherits="logn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="hkLogin/css/demo.css" />
    <link rel="stylesheet" type="text/css" href="hkLogin/css/style1.css" />
    <link rel="stylesheet" type="text/css" href="hkLogin/login.css" />
    <link href="hkLogin/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body id="page">
    <form id="form1" runat="server">
    <div class="background">
    </div>
    <ul class="cb-slideshow">
        <li><span></span>
            <div id="div1">
            </div>
        </li>
        <li><span></span>
            <div>
            </div>
        </li>
        <li><span></span>
            <div>
            </div>
        </li>
        <li><span></span>
            <div>
            </div>
        </li>
        <li><span></span>
            <div>
            </div>
        </li>
        <li><span></span>
            <div>
            </div>
        </li>
    </ul>
    <div class="container">
        <div>
            <br />
            <br>
            <h2 style="color: White;">
                <strong>Hare Krishna Diamond Institute</strong>
            </h2>
        </div>
        <div class="codrops-top">
            <div class="transbox">
                <div class="form-top">
                    <div class="form-top-left">
                        <h3>
                            Login to our site</h3>
                        <p>
                            Enter your username and password to log on</p>
                    </div>
                    <div class="form-top-right">
                        <i class="fa fa-lock"></i>
                    </div>
                </div>
                <div class="form-bottom">
                    <div class="login-form">
                        <div class="form-group">
                            <label class="sr-only" for="form-username">
                                Username</label>
                            <asp:TextBox runat="server" ID="txtUname" placeholder="Username" CssClass="form-username form-control"
                                CssClassID="form-username"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="sr-only" for="form-password">
                                Password</label>
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Password"
                                CssClass="form-password form-control" CssClassID="form-password"></asp:TextBox>
                        </div>
                        <asp:Button runat="server" Text="Sign In" CssClass="btn" ID="btnLogin" OnClick="btnLogin_Click" BackColor="#FF9900" />
                    </div>
                </div>
                <%--   <p>
                Login to Continue
            </p>
            <hr />
            
                <table style="margin-left: 10%" cellpadding="5px" cellspacing="10px">
                    <tr>
                        <td>
                            UserName:
                        </td>
                        <td>
                         <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Password:
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
                        </td>
                    </tr>
                </table>--%>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
