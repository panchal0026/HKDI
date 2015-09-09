using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class faculty_LeaveNotification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            bindLeaveInfo();
        }
    }

    public void bindLeaveInfo()
    {
        clsFaculty f=new clsFaculty();
        int f_id = f.getFacultyIDbyEmail(Session["UserName"].ToString());
        clsLeaveNotification ln = new clsLeaveNotification();
        DataSet ds = ln.ListLeaveNotifications(f_id);
        gvLeaveNotification.DataSource = ds;
        gvLeaveNotification.DataBind();
    }

   

    protected void ckIsApproved_CheckedChanged(object sender,EventArgs e) 
    {
        
        GridViewRow gr = (GridViewRow)((DataControlFieldCell)((CheckBox)sender).Parent).Parent;
        HiddenField hfLeveID = (HiddenField) gr.FindControl("hfLeaveID");
        int leaveID = Convert.ToInt32(hfLeveID.Value);
        clsLeaveNotification clLeave = new clsLeaveNotification();
        bool i = clLeave.AprroveLeave(leaveID);
        if (i)
        {
            bindLeaveInfo();
        }
        else 
        {

        }

    }
    protected void ckIsRejected_CheckedChanged(object sender, EventArgs e)
    {

        GridViewRow gr = (GridViewRow)((DataControlFieldCell)((CheckBox)sender).Parent).Parent;
        HiddenField hfLeveID = (HiddenField)gr.FindControl("hfLeaveID");
        int leaveID = Convert.ToInt32(hfLeveID.Value);
        clsLeaveNotification clLeave = new clsLeaveNotification();
        bool i = clLeave.RejectLeave(leaveID);
        if (i) 
        {
            bindLeaveInfo();
        }
        else
        {

        }

    }

    protected void gvLeaveNotification_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
}