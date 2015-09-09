using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class student_RequestJump : System.Web.UI.Page
{
    string uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserName"] != null)
            {
                uname = Session["UserName"].ToString();
                bindJumpInfo();
            }
        }

    }
    public void bindJumpInfo()
    {
        clsJump cs = new clsJump();
        DataSet ds = cs.ListJump(uname);
        gvJumpRequest.DataSource = ds;
        gvJumpRequest.DataBind();
        if (ds.Tables[0].Rows.Count > 0) 
        {
            btnRequestNewJump.Visible = false;
            pnlNotification.Visible = true;
        }
    }
    protected void btnSaveReason_Click(object sender, EventArgs e) 
    {
        clsJump j = new clsJump();
        j.Reason = txtReason.Text;
        j.Student_ID = Convert.ToInt32(Session["Student_ID"]);
        j.RequestJump(j);
        bindJumpInfo();
        pnlform.Visible = false;
        pnldata.Visible = true;
        
    }
    protected void btnRequestNewJump_Click(object sender, EventArgs e) 
    {
        pnlform.Visible = true;
        pnldata.Visible = false;
    }
}

            //clsFaculty cf = new clsFaculty();
            //facultyEmail = cf.GetFacultyEmailbyID(Convert.ToInt32(Session["facultyID"]));
            //newLeave.facultyID = Convert.ToInt32(Session["facultyID"]);
            //newLeave.Student_ID = Convert.ToInt32(Session["Student_ID"]);
            //newLeave.from_Date = Convert.ToDateTime(txtFromLeave.Text);
            //newLeave.to_Date= Convert.ToDateTime(txtToLeave.Text);
            //newLeave.comments = txtComments.Text;
            //newLeave.IsApproved = false;
            //newLeave.requestLeave(newLeave);
            //pnldata.Visible = true;
            //pnlform.Visible = false;
            //bindLeaveInfo();

            //string body = "Studetn with Student ID" + newLeave.Student_ID + " has requesteed leave from  ";
            //mailing ms = new mailing();
            //ms.SendEmail(facultyEmail,"Leave Notification", body);