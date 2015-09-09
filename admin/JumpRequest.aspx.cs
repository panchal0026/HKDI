using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_JumpRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            bindJumpNotification();
        }
    }

    public void bindJumpNotification()
    {
        clsJump j = new clsJump();
        DataSet ds = j.ListJumpRequests(j);
        gvJumpNotification.DataSource = ds;
        gvJumpNotification.DataBind();
    }
    protected void ckIsApproved_CheckedChanged(object sender, EventArgs e) 
    {
        GridViewRow gr = (GridViewRow)((DataControlFieldCell)((CheckBox)sender).Parent).Parent;
        HiddenField hfStudentID = (HiddenField)gr.FindControl("hfStudentID");
        int StudentID = Convert.ToInt32(hfStudentID.Value);
        clsJump j = new clsJump();
        bool i = j.AllowJump(StudentID);
        if (i)
        {
            bindJumpNotification();
        }
        else
        {

        }
    }
    protected void ckIsRejected_CheckedChanged(object sender, EventArgs e)
    {

        GridViewRow gr = (GridViewRow)((DataControlFieldCell)((CheckBox)sender).Parent).Parent;
        HiddenField hfStudentID = (HiddenField)gr.FindControl("hfStudentID");
        int StudentID = Convert.ToInt32(hfStudentID.Value);
        clsJump j = new clsJump();
        bool i = j.RejectJump(StudentID);
        if (i)
        {
            bindJumpNotification();
        }
        else
        {

        }
    }
}