using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

public partial class StudyMaterial : System.Web.UI.Page
{
    string uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            uname = Session["UserName"].ToString();
            clsFaculty f = new clsFaculty();
            DataSet ds = f.GetFacultyName(uname);
            lblFacultyName.Text = ds.Tables[0].Rows[0]["Faculty_name"].ToString();
            hfFacultyID.Value = ds.Tables[0].Rows[0]["Faculty_id"].ToString();
            bindMaterial();
           
        }

    }
    public void bindMaterial() 
    {
        clsStudyMaterial sm = new clsStudyMaterial();
        DataSet ds = sm.ListMaterial(Convert.ToInt32(hfFacultyID.Value));
        gvStudyMaterial.DataSource = ds;
        gvStudyMaterial.DataBind();

    }
    protected void btnAddMaterial_Click(object sender, EventArgs e) 
    {
        pnldata.Visible = false;
        pnlform.Visible = true;
    }

    protected void btnSubmitStudyMaterial_Click(object sender, EventArgs e) 
    {
        clsStudyMaterial sm = new clsStudyMaterial();
        sm.Course_ID = Convert.ToInt32(ddCourse.SelectedValue);
        sm.Faculty_ID = Convert.ToInt32(hfFacultyID.Value);
        sm.Subject_ID = Convert.ToInt32(ddSubject.SelectedValue);
        sm.Title = txtTitle.Text;
        sm.Description = txtMaterialDescription.Text;
        sm.Upload_Date = DateTime.Now;
        if (FileUpload.HasFile)
        {

            string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
            string path = "../StudyMaterial/" + filename;
            FileUpload.SaveAs(Server.MapPath("~/StudyMaterial/") + filename);
            sm.File_Path = path;
            // Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Image saved!')", true);
            if (!string.IsNullOrEmpty(hfFacultyID.Value) && !string.IsNullOrEmpty(ddSubject.SelectedValue) && !string.IsNullOrEmpty(ddCourse.SelectedValue))
            {
                sm.AddStudyMaterial(sm);
                bindMaterial();
                pnlform.Visible = false;
                pnldata.Visible = true;
                ddCourse.SelectedValue = "";
                ddSubject.SelectedValue = "";
                txtTitle.Text = "";
                txtMaterialDescription.Text = "";

            }
            
        }

    }
}