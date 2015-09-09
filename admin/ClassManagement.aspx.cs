using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_ClassManagement : System.Web.UI.Page
{
    public int Admission_Year_ID
    {
        get
        {
            int o = Convert.ToInt32(ViewState["Admission_Year_ID"]);
            return (o == 0) ? 0 : (int)o;
        }

        set
        {
            ViewState["Class_ID"] = value;
        }
    }

    public string Year
    {
        get
        {
            string o = (ViewState["Year"]).ToString();
            return (o == null) ? string.Empty : (string)o;
        }

        set
        {
            ViewState["Year"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Admission_Year_ID"]))
            {
                ViewState["Admission_Year_ID"] = Request.QueryString["Admission_Year_ID"];
                Admission_Year_ID = Convert.ToInt32(Request.QueryString["Admission_Year_ID"]);
                Year =  Request.QueryString["Year"];
                txtYear.Text = Year;
                bindClass(Admission_Year_ID);
            }
        }
    }

    public void bindClass(int yearID) 
    {
        clsNewAdmissionClass ca = new clsNewAdmissionClass();
        DataSet ds = ca.listClassbyAdmissionYearID(yearID);
        grid_Class.DataSource = ds;
        grid_Class.DataBind();
    }

    #region Control Events

    protected void btnCreateClass_Click(object sender,EventArgs e) 
    {
        clsNewAdmissionClass cs = new clsNewAdmissionClass();
        cs.Class_Name = txtClassName.Text;
        cs.Admission_Year_ID = Convert.ToInt32(Admission_Year_ID);
        cs.addClass(cs);
        pnlForm.Visible = false;
        pnlGrid.Visible = true;
        bindClass(Admission_Year_ID);
    }

    protected void btnAddClass_Click(object sender,EventArgs e) 
    {
        pnlGrid.Visible = false;
        pnlForm.Visible = true;
    }

    #endregion
}