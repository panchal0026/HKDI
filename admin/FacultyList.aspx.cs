using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Security;
using System.IO;
public partial class admin_FacultyList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            bindfacultygrid();
        }

    }
    protected void btnAddFaculty_Click(object sender, EventArgs e) 
    {
        pnlData.Visible = false;
        pnlForm.Visible = true;
    }
    public void bindfacultygrid()
    {
        clsFaculty f = new clsFaculty();
        DataSet ds = f.listFaculty();
        gvFaculty.DataSource = ds;
        gvFaculty.DataBind();

    }
    protected void btnsubmit_Click(object sender,EventArgs e) 
    {

        MembershipCreateStatus status;
        Membership.CreateUser(txtFacultyemailid.Text, txtFacultypassword.Text, txtFacultyemailid.Text, "Que", "Ans", true, out status);
        if (status == MembershipCreateStatus.Success)
        {
            Roles.AddUserToRole(txtFacultyemailid.Text, "faculty");
            clsFaculty f = new clsFaculty();
            f.Faculty_name = txtFacultyname.Text;
            f.Faculty_email = txtFacultyemailid.Text;
            f.Faculty_password = txtFacultypassword.Text;
            f.Faculty_contactno = txtFacultycontactno.Text;
            f.Faculty_address = txtFacultyaddress.Text;
            f.Faculty_AreaOfInterest = txtFacultyAreaOfInterest.Text;
            f.Faculty_Experience = txtFacultyExperience.Text;
            
            f.Faculty_courseid = Convert.ToInt32(txtFacultycourseid.Text);
            f.Faculty_batchno = Convert.ToInt32(txtFacultybatchno.Text);
            if (fileupload.HasFile)
            {

                string filename = Path.GetFileName(fileupload.PostedFile.FileName);
                string path = "../images/" + filename;
                fileupload.SaveAs(Server.MapPath("~/images/") + filename);
                f.Faculty_Image= path;
                // Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Image saved!')", true);
            }
            if (!string.IsNullOrEmpty(txtFacultyname.Text) && !string.IsNullOrEmpty(txtFacultyemailid.Text) && !string.IsNullOrEmpty(txtFacultypassword.Text) && !string.IsNullOrEmpty(txtFacultycontactno.Text) && !string.IsNullOrEmpty(txtFacultyaddress.Text) && !string.IsNullOrEmpty(txtFacultyAreaOfInterest.Text) && !string.IsNullOrEmpty(txtFacultyExperience.Text) && !string.IsNullOrEmpty(txtFacultycourseid.Text) && !string.IsNullOrEmpty(txtFacultybatchno.Text))
            {
                try
                {
                    f.addFaculty(f);
                    string body = "Congratulations" + f.Faculty_name+ "You are successfully registered as Faculty. Welcome to Hare Krishna Diamond Institute";
                    mailing ms = new mailing();
                    ms.SendEmail(f.Faculty_email, "Faculty Confirmation", body);
                }
                catch (Exception ex) 
                {
                    Membership.DeleteUser(txtFacultyemailid.Text);
                }
                bindfacultygrid();
                pnlData.Visible = true;
                pnlForm.Visible = false;
                txtFacultyname.Text = "";
                txtFacultyemailid.Text = "";
                txtFacultypassword.Text = "";
                txtFacultycontactno.Text = "";
                txtFacultyaddress.Text = "";
                txtFacultyAreaOfInterest.Text = "";
                txtFacultyExperience.Text = "";
                txtFacultycourseid.Text = "";
                txtFacultybatchno.Text = "";
            }
        }
    }
    protected void btncancel_Click(object sender,EventArgs e)
    {

    }
}