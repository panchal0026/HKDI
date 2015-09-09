using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class student_LeaveNotification : System.Web.UI.Page
{
    string facultyEmail;
    string uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserName"] != null)
            {
                uname = Session["UserName"].ToString();
                bindLeaveInfo();
            }
        }
    }
    public void bindLeaveInfo() 
    {
        clsLeaveNotification ln = new clsLeaveNotification();
        DataSet ds = ln.ListLeave(uname);
        gvLeaveNotification.DataSource = ds;
        gvLeaveNotification.DataBind();
    }
    protected void btnSubmitLeaveRequest_Click(object sender, EventArgs e)
    {
        clsLeaveNotification newLeave = new clsLeaveNotification();
        
        if (Session["facultyID"] != null)
        {
            clsFaculty cf = new clsFaculty();
            facultyEmail = cf.GetFacultyEmailbyID(Convert.ToInt32(Session["facultyID"]));
            newLeave.facultyID = Convert.ToInt32(Session["facultyID"]);
            newLeave.Student_ID = Convert.ToInt32(Session["Student_ID"]);
            newLeave.from_Date = Convert.ToDateTime(txtFromLeave.Text);
            newLeave.to_Date= Convert.ToDateTime(txtToLeave.Text);
            newLeave.comments = txtComments.Text;
            newLeave.IsApproved = false;
            newLeave.requestLeave(newLeave);
            pnldata.Visible = true;
            pnlform.Visible = false;
            bindLeaveInfo();

            string body = "Studetn with Student ID" + newLeave.Student_ID + " has requesteed leave from  ";
            mailing ms = new mailing();
            ms.SendEmail(facultyEmail,"Leave Notification", body);
        }
    }
    protected void txtRequestNewLeave_Click(object sender, EventArgs e) 
    {
        pnlform.Visible = true;     
        pnldata.Visible = false;
    }
    
}