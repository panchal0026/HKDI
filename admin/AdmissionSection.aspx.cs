using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_AdmissionSection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            bindCourseDropDown();
            bindAdmissionYearGrid();
        }
    }

    #region Methods
    public void bindCourseDropDown() 
    {
        clsAdmissionYear ca = new clsAdmissionYear();
        DataSet ds = ca.ListCourse();
        drpCourse.DataSource = ds;
        drpCourse.DataTextField = "Course_Name";
        drpCourse.DataValueField = "Course_ID";
        drpCourse.DataBind();
    }

    public void bindAdmissionYearGrid()
    {
        clsAdmissionYear ca = new clsAdmissionYear();
        DataSet ds = ca.ListAdmissionYears();
        grid_AdmissionYear.DataSource = ds;
        grid_AdmissionYear.DataBind();
    }
    #endregion

    #region Control Events
    protected void btnSaveYear_Click(object sender,EventArgs e) 
    {
        clsAdmissionYear newAdmissionYear = new clsAdmissionYear();
        if (!string.IsNullOrEmpty(txtYear.Text)) 
        {
            newAdmissionYear.Year = txtYear.Text;
            newAdmissionYear.YearName = drpCourse.SelectedItem +" Programme "+ txtYear.Text ;
            newAdmissionYear.Course_ID = Convert.ToInt32(drpCourse.SelectedValue);
            newAdmissionYear.IsDeleted = false;
            newAdmissionYear.addAdmissionYear(newAdmissionYear);
            pnlgrid.Visible = true;
            pnlform.Visible = false;
            bindAdmissionYearGrid();
        }
    }

    protected void btnAddAdmission_Click(object sender,EventArgs e) 
    {
        pnlform.Visible = true;
        pnlgrid.Visible = false;
    }

    

    #endregion
    protected void grid_AdmissionYear_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("DeleteYear")) 
        {
            clsAdmissionYear year = new clsAdmissionYear();
            int Admission_Year_ID = Convert.ToInt32(e.CommandArgument);
            year.DeleteYear(Admission_Year_ID);
            bindAdmissionYearGrid();
        }
    }
}