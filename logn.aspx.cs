using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class logn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        WebService w = new WebService();
        //int  i = w.login(txtUname.Text, txtPassword.Text);
        //if (i == 1) 
        //{
        //    Response.Redirect("~/admin/Dashboard.aspx");
        //}
        //if (i == 2) 
        //{
        //    Response.Redirect("~/faculty/FacultyDashboard.aspx");
        //}
        //if (i == 3) 
        //{
        //    Response.Redirect("~/student/StudentDashboard.aspx");
        //}
        //if (i == 0) 
        //{
        //    Response.Redirect("~/logn.aspx");
        //}

        bool loginstatus = w.login1(txtUname.Text, txtPassword.Text);
        try
        {
            if (loginstatus)
            {
                MembershipUser user = Membership.GetUser(txtUname.Text);
                Session["UserID"] = user.ProviderUserKey;
                Session["UserName"] = user.UserName;
                if (Roles.IsUserInRole(txtUname.Text, "admin"))
                {
                    Response.Redirect("~/admin/Dashboard.aspx");
                }
                if (Roles.IsUserInRole(txtUname.Text, "faculty"))
                {
                    Response.Redirect("~/faculty/FacultyDashboard.aspx");
                }
                if (Roles.IsUserInRole(txtUname.Text, "student"))
                {
                    Response.Redirect("~/student/StudentDashboard.aspx");
                }
            }

        }
        catch (Exception ex)
        {

        }


    }
}