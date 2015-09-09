using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Attendance : System.Web.UI.Page
{
    #region Page Events
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindYearDropdown();
        }
    }

    #endregion

    #region Methods

    public void bindStudents(int Admission_Year_ID,int Class_ID) 
    {
        clsStudent stud = new clsStudent();
        DataSet ds =  stud.listStudentByAdmission_Year_ID(Admission_Year_ID, Class_ID);
        rpt_Students.DataSource = ds.Tables[0];
        rpt_Students.DataBind();
    }


    #endregion

    #region Control Events

    
    protected void btnSaveAttendance_Click(object sender,EventArgs e) 
    {
        StudentAttendance st = new StudentAttendance();
        st.Course_ID = Convert.ToInt32(ddCourse.SelectedValue);
        st.Lecture_Date = Convert.ToDateTime(txtAttendanceDate.Text);
        st.Subject_ID = Convert.ToInt32(ddSubject.SelectedValue);
        st.Session_ID = Convert.ToInt32(ddSession.SelectedValue);

        if (rpt_Students.Items.Count > 0) 
        {
            foreach (RepeaterItem i in rpt_Students.Items) 
            {
                Label lblID = (Label)i.FindControl("lblStud_ID");
                st.Student_ID = Convert.ToInt32(lblID.Text);
                CheckBox cbAtt = (CheckBox) i.FindControl("cbAttendance");
                st.Attendance = cbAtt.Checked;
                st.AddAttendance(st);
            }
        }
    }

    protected void drp_ClassID_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Admission_Year_ID = Convert.ToInt32(ddCourse.SelectedValue);
        int Class_ID = Convert.ToInt32(drp_ClassID.SelectedValue);
        bindStudents(Admission_Year_ID, Class_ID);
        pnlStudentList.Visible = true;
    }

    protected void ddCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
          if (ddCourse.SelectedIndex > 0)
            {
                int Admission_Year_ID = Convert.ToInt32(ddCourse.SelectedValue);
                clsStudent stud = new clsStudent();
                DataSet ds = stud.listClassIDbyAdmissionProgramme(Admission_Year_ID);
                drp_ClassID.DataSource = ds.Tables[0];
                drp_ClassID.DataTextField = "Class_Name";
                drp_ClassID.DataValueField = "Class_ID";
                drp_ClassID.DataBind();
                drp_ClassID.Items.Insert(0, new ListItem("Select One", "-1"));
            }
        }
       
    
    protected void BindYearDropdown()
    {
        clsStudent cs = new clsStudent();
        DataSet ds = cs.SelectAdYear();
        ddCourse.DataSource = ds;
        ddCourse.DataTextField = "YearName";
        ddCourse.DataValueField = "Admission_Year_ID";
        ddCourse.DataBind();
        ddCourse.Items.Insert(0, new ListItem("Select Year", "-1"));

    }
    
    #endregion
}
