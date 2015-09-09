using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class student_AcademicRecords : System.Web.UI.Page
{
    string uname;
    int Student_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserName"] != null)
            {
                uname = Session["UserName"].ToString();
                Student_ID = Convert.ToInt32(Session["Student_ID"]);
                bindStudentAttendance(Student_ID);
            }
        }
    }
    public void bindStudentAttendance(int Student_ID)
    {
        clsStudent cs = new clsStudent();
        DataSet ds = cs.StudentAttendance(Student_ID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblStudent_Name.Text=ds.Tables[0].Rows[0]["Student_Name"].ToString();
            lblLectureConducted.Text=ds.Tables[0].Rows[0]["LectureConducted"].ToString();
            lblAbsent.Text = ds.Tables[0].Rows[0]["Abse"].ToString();
            lblPresent.Text = ds.Tables[0].Rows[0]["Present"].ToString();
            
          
        }

        
    }
}