using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class StudentMarks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindYearDropdown();
        }   
    }
    public void bindStudents(int Admission_Year_ID, int Class_ID)
    {
        clsStudent stud = new clsStudent();
        DataSet ds = stud.listStudentByAdmission_Year_ID(Admission_Year_ID, Class_ID);
        rpt_StudentMarks.DataSource = ds.Tables[0];
        rpt_StudentMarks.DataBind();
    }

    //public void bindStudents(int Course_ID, int Class_ID)
    //{
    //    clsStudent stud = new clsStudent();
    //    DataSet ds = stud.listStudentByClassID(Course_ID, Class_ID);
    //    rpt_StudentMarks.DataSource = ds.Tables[0];
    //    rpt_StudentMarks.DataBind();
    //}
    protected void btnSaveMarks_Click(object sender, EventArgs e)
    {
        clsStudentMarks sm = new clsStudentMarks();
        sm.Course_ID = Convert.ToInt32(ddCourse.SelectedValue);
        sm.Subject_ID = Convert.ToInt32(ddSubject.SelectedValue);
        sm.Exam_Date = Convert.ToDateTime(txtExamDate.Text);

        if (rpt_StudentMarks.Items.Count > 0)
        {
            foreach (RepeaterItem i in rpt_StudentMarks.Items)
            {
                Label lblID = (Label)i.FindControl("lblStud_ID");
                sm.Student_ID = Convert.ToInt32(lblID.Text);
                TextBox tb = (TextBox)i.FindControl("txtStudentMarks");
                sm.Obtained_Marks = tb.Text;
                sm.AddStudentMarks(sm);
            }
        }
    }
    //protected void drp_ClassID_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    int Course_ID = Convert.ToInt32(ddCourse.SelectedValue);
    //    int Class_ID = Convert.ToInt32(drp_ClassID.SelectedValue);
    //    bindStudents(Course_ID, Class_ID);
    //    pnlStudentMarks.Visible = true;
    //}

    //protected void ddCourse_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddCourse.SelectedIndex > 0)
    //    {
    //        int Course_ID = Convert.ToInt32(ddCourse.SelectedValue);
    //        clsStudent stud = new clsStudent();
    //        DataSet ds = stud.listClassIDbyCourse(Course_ID);
    //        drp_ClassID.DataSource = ds.Tables[0];
    //        drp_ClassID.DataTextField = "Class_ID";
    //        drp_ClassID.DataValueField = "Class_ID";
    //        drp_ClassID.DataBind();
    //        drp_ClassID.Items.Insert(0, new ListItem("Select One", "-1"));
    //    }
    //}
    protected void drp_ClassID_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Admission_Year_ID = Convert.ToInt32(ddCourse.SelectedValue);
        int Class_ID = Convert.ToInt32(drp_ClassID.SelectedValue);
        bindStudents(Admission_Year_ID, Class_ID);
        pnlStudentMarks.Visible = true;
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

}