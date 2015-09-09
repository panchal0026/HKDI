using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class FacultyMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string uname = "";
        if (Session["UserName"] != null)
        {
            uname = Session["UserName"].ToString();
            if (!Roles.IsUserInRole(uname, "faculty"))
            {
                Response.Redirect("~/Login.aspx");
            }
            //else if (!Roles.IsUserInRole(uname, "faculty"))
            //{
            //    Response.Redirect("~/Login.aspx");
            //}
        }
        else
        {
            Response.Redirect("~/faculty/FacultyDashboard.aspx");
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }
}