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


public partial class StudentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindstudentgrid();
            BindYearDropdown();
            bindFacultyDropDown();
        }

    }

    public void bindstudentgrid()
    {
        clsStudent s = new clsStudent();
        DataSet ds = s.listStudent();
        gvstudent.DataSource = ds;
        gvstudent.DataBind();

    }

    protected void btnsubmitstudent_Click(object sender, EventArgs e) 
    {
        MembershipCreateStatus status;
        Membership.CreateUser(txtstudentemailid.Text, txtstudentpassword.Text, txtstudentemailid.Text, "Que", "Ans", true, out status);
        if (status == MembershipCreateStatus.Success)
        {

            Roles.AddUserToRole(txtstudentemailid.Text, "student");
            clsStudent s = new clsStudent();
            
            s.Student_name = txtstudentname.Text;
            s.Admission_Year_ID = Convert.ToInt32(ddCourse.SelectedValue);
            s.Contact_No = txtstudentcontactno.Text;
            s.Email = txtstudentemailid.Text;
            s.Password = txtstudentpassword.Text;
            s.Class_ID = Convert.ToInt32(drp_ClassID.SelectedValue);
            s.Current_Subject_ID =1;
            s.Faculty_ID =Convert.ToInt32(drpFaculty.SelectedValue);
            if (!string.IsNullOrEmpty(s.Student_name) && !string.IsNullOrEmpty(s.Contact_No) && !string.IsNullOrEmpty(s.Email) && !string.IsNullOrEmpty(s.Password) && !string.IsNullOrEmpty(drp_ClassID.SelectedValue)  && !string.IsNullOrEmpty(drpFaculty.SelectedValue))
            {
                try
                {
                    s.addStudent(s);
                    string body = "Congratulations" + s.Student_name + "You are successfully registered.Welcome to Hare Krishna Diamond Institute";
                    mailing ms = new mailing();
                    ms.SendEmail(s.Email, "Admission Registered", body);
                }
                catch (Exception ex)
                {
                    Membership.DeleteUser(txtstudentemailid.Text);
                }
                bindstudentgrid();
                pnldata.Visible = true;
                pnlform.Visible = false;
                txtstudentname.Text = "";
                txtstudentemailid.Text = "";
                txtstudentpassword.Text = "";
                txtstudentcontactno.Text = "";
                
                //ddCourse.SelectedValue= "";
                
                drpFaculty.SelectedIndex= 0;
                txtCurrentSubject.Text = "";

            }
        }
        }

    protected void gvstudent_RowCommand(object sender,GridViewCommandEventArgs e) 
    {
        if (e.CommandName == "change_Password") 
        {
            string email = e.CommandArgument.ToString();
            hfEmailID.Value = email;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Func_PopUp()", true);
        }
        if (e.CommandName == "remove_Student")
        {
            string email = e.CommandArgument.ToString();
            hfEmailID.Value = email;
            if (!string.IsNullOrEmpty(hfEmailID.Value)) 
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Are you sure you want to delete the role');</script>");
                clsStudent cs = new clsStudent();
                cs.removeStudent(email);    
                Membership.DeleteUser(email);
                bindstudentgrid();

            }
        }
    }

    protected void btnNewPassword_Click(object sender,EventArgs e) 
    {
        if (!string.IsNullOrEmpty(hfEmailID.Value))
        {
            MembershipUser membershipUser = Membership.GetUser(hfEmailID.Value);
            string temporaryPassword = membershipUser.ResetPassword();
            try
            {
                Membership.UpdateUser(membershipUser);
                membershipUser.ChangePassword(temporaryPassword, txtNewPassword.Text);
                Membership.UpdateUser(membershipUser);
                //lblPassMessage.Text = "Password Change Successfully.";

            }
            catch (Exception ex)
            {
                //lblPassErrorMessage.Text = "Error Occured. Can not Change Password";
            }
        }
    }
    //protected void drp_ClassID_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    int Course_ID = Convert.ToInt32(ddCourse.SelectedValue);
    //    int Class_ID = Convert.ToInt32(drp_ClassID.SelectedValue);
        
       
    //}
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
    //protected void drpAdmissionYear_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        clsStudent cs = new clsStudent();
    //        DataSet ds = cs.SelectAdYear(cs);
    //        drpAdmissionYear.DataSource = ds;
    //        drpAdmissionYear.DataTextField = "Admission_Year";
    //        drpAdmissionYear.DataValueField = "Admission_Year";
    //        drpAdmissionYear.DataBind();
    //    }
    //    catch (Exception ex)
    //    {
    //    }


    //}

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

    public void bindFacultyDropDown() 
    {
        clsFaculty cf = new clsFaculty();
        DataSet ds = cf.listFaculty();
        drpFaculty.DataSource = ds;
        drpFaculty.DataTextField = "Faculty_name";
        drpFaculty.DataValueField = "Faculty_id";
        drpFaculty.DataBind();
        drpFaculty.Items.Insert(0, new ListItem("Select Faculty", "-1"));
    }
}