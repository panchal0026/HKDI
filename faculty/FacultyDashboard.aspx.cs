using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class FacultyDashboard : System.Web.UI.Page
{
    string uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserName"] != null)
            {
                uname = Session["UserName"].ToString();
                bindStudent();
            }
        }
    }
   public void bindStudent()
   {
       clsFaculty cs = new clsFaculty();
       DataSet ds = cs.getStudentByFacultyUsername(uname);
       gv_StudentList.DataSource = ds;
       gv_StudentList.DataBind();
   }
}