using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Security;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod]
    public DataSet Faculty_login(string uname, string pwd)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from tblFaculty where Faculty_email_id ='" + uname + "' and Faculty_password='" + pwd + "' ",
        @"Data Source=ISHANI-PC;Initial Catalog=HKDI;User ID=sa;Password=i1010");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    [WebMethod]
    public DataSet Student_login(string uname, string pwd)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from tblStudent where Email ='" + uname + "' and Password='" + pwd + "' ",
        @"Data Source=ISHANI-PC;Initial Catalog=HKDI;User ID=sa;Password=i1010");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    [WebMethod]
    public int login(string username,string password) 
    {
        int i = 0;
        bool loginstatus = Membership.ValidateUser(username, password);
        try
        {
            if (loginstatus)
            {
                MembershipUser user = Membership.GetUser(username);
                Session["UserID"] = user.ProviderUserKey;
                Session["UserName"] = user.UserName;
                if (Roles.IsUserInRole(username, "admin"))
                {
                    i = 1;
                    return i;
                    //Ressponse.Redirect("~/admin/Dashboard.aspx");
                }
                if (Roles.IsUserInRole(username, "faculty"))
                {
                    i = 2;
                    return i;
                    //Response.Redirect("~/faculty/FacultyDashboard.aspx");
                }
                if (Roles.IsUserInRole(username, "student"))
                {
                    i = 3;
                    return i;
                    //Response.Redirect("~/student/StudentDashboard.aspx");
                }
                return i;
            }
            return i;
        }
        catch(Exception ex)
        {
            return 0;
        }
    }

    [WebMethod]
    public bool login1(string uname,string pass) 
    {
        bool loginStatus;
        loginStatus = Membership.ValidateUser(uname, pass);
        return loginStatus;
    }
    
}
