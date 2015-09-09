using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack) 
        //{
        //    if (Request.Cookies["Count"] != null)
        //    {
        //        int i = Convert.ToInt32(Request.Cookies["Count"].Value);
        //        lblVisit.Text = "Total Visit = " + i;
        //        i++;
        //        HttpCookie cs = new HttpCookie("Count");
        //        cs.Value = i.ToString();
        //        Response.Cookies.Add(cs);
        //    }
        //    else 
        //    {
        //        HttpCookie cs = new HttpCookie("Count", "1");
        //        Response.Cookies.Add(cs);
        //    }

        //}

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        bool loginstatus = Membership.ValidateUser(txtUname.Text, txtPassword.Text);
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