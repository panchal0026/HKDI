using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class student_StudentDashboard : System.Web.UI.Page
{
    string uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserName"] != null)
            {
                uname = Session["UserName"].ToString();
                bindStudentInfo();
            }
        }
    }
    public void bindStudentInfo()
    {
        clsStudent cs = new clsStudent();
        DataSet ds = cs.GetStudentInfoByUsername(uname);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblAdmission_Year_ID.Text = ds.Tables[0].Rows[0]["Admission_Year_ID"].ToString();
            lblStudent_ID.Text = ds.Tables[0].Rows[0]["Student_ID"].ToString();
            lblStudent_Name.Text = ds.Tables[0].Rows[0]["Student_Name"].ToString();
            lblContact_No.Text = ds.Tables[0].Rows[0]["Contact_No"].ToString();
            lblEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            lblPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
            lblClass_ID.Text = ds.Tables[0].Rows[0]["Class_ID"].ToString();
            lblCurrent_Subject_ID.Text = ds.Tables[0].Rows[0]["Current_Subject_ID"].ToString();
            lblFaculty.Text = ds.Tables[0].Rows[0]["Faculty_Name"].ToString();
            Session["facultyID"] = ds.Tables[0].Rows[0]["Faculty_ID"].ToString();
            Session["Student_ID"] = ds.Tables[0].Rows[0]["Student_ID"].ToString();
        }

        
    }
}