using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class faculty_FacultyProfile : System.Web.UI.Page
{
    string uname;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            if (Session["UserName"] != null)
            {
                uname = Session["UserName"].ToString();
                bindFacultyImage();
                bindFacultyName();
                bindInterest();
                bindNews();
                bindFacultyInfo();
                clsFaculty f = new clsFaculty();
                DataSet ds = f.GetFacultyName(uname);
                hfFacultyID.Value = ds.Tables[0].Rows[0]["Faculty_id"].ToString();
                bindMaterial();
                //hfFacultyID.Value = ds.Tables[0].Rows[0]["Faculty_id"].ToString();
                 
            }
        }
    }
    public void bindNews()
    {
        clsNews n = new clsNews();
        DataSet ds = n.ListNews();
        rptNews.DataSource = ds;
        rptNews.DataBind();
    }
    public void bindFacultyImage()
    {
        clsFaculty f = new clsFaculty();
        DataSet ds = f.GetFacultyImageByUsername(uname);
        dl1.DataSource = ds;
        dl1.DataBind();
        //dl1.DataBind();

    }
    public void bindInterest()
    {
        clsFaculty f = new clsFaculty();
        DataSet ds = f.GetAreaOfInterestOfFacultyByUserName(uname);
        dl2.DataSource = ds;
        dl2.DataBind();
    }
    public void bindFacultyName()
    {
        clsFaculty f = new clsFaculty();
        DataSet ds = f.GetFacultyName(uname);
        dlName.DataSource = ds;
        dlName.DataBind();
    }
    public void bindFacultyInfo()
    {
        clsFaculty f = new clsFaculty();
        DataSet ds = f.GetFacultyInfo(uname);
        dlInfo.DataSource = ds;
        dlInfo.DataBind();
    }
    public void bindMaterial()
    {
        clsStudyMaterial m = new clsStudyMaterial();
        DataSet ds = m.ListMaterial(Convert.ToInt32(hfFacultyID.Value));
        rpMaterial.DataSource = ds;
        rpMaterial.DataBind();

    }
}