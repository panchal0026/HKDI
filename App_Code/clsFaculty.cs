using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsFaculty
/// </summary>
public class clsFaculty
{
    public string Faculty_name { get; set; }
    public string Faculty_email { get; set; }
    public string Faculty_password { get; set; }
    public string Faculty_contactno { get; set; }
    public string Faculty_address { get; set; }
    public string Faculty_AreaOfInterest{ get; set; }
    public string Faculty_Experience { get; set; }
    public string Faculty_Image { get; set; }
    public int Faculty_courseid { get; set; }
    public int Faculty_batchno { get; set; }

    public clsFaculty()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool addFaculty(clsFaculty f)
    {
        SqlParameter[] sp = new SqlParameter[10];
        sp[0] = new SqlParameter("@Faculty_name", f.Faculty_name);
        sp[1] = new SqlParameter("@Faculty_email", f.Faculty_email);
        sp[2] = new SqlParameter("@Faculty_password", f.Faculty_password);
        sp[3] = new SqlParameter("@Faculty_contact_no", f.Faculty_contactno);
        sp[4] = new SqlParameter("@Faculty_address", f.Faculty_address);
        sp[5] = new SqlParameter("@Faculty_AreaOfInterest", f.Faculty_AreaOfInterest);
        sp[6] = new SqlParameter("@Faculty_Experience", f.Faculty_Experience);
        sp[7] = new SqlParameter("@Faculty_Image", f.Faculty_Image);
        sp[8] = new SqlParameter("@Faculty_course_id", f.Faculty_courseid);
        sp[9] = new SqlParameter("@Faculty_batch_no", f.Faculty_batchno);
        return datalayer.Execute_NonQuery("sp_addFaculty", CommandType.StoredProcedure, sp);
    }
    public DataSet listFaculty()
    {
        return datalayer.get_data("sp_listfaculty", CommandType.StoredProcedure, null);
    }
    public DataSet getStudentByFacultyUsername(string UserName)
    {

        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        DataSet ds = datalayer.get_data("sp_getStudentByFacultyUsername", CommandType.StoredProcedure, sp);
        return ds;
    }

    public int getFacultyIDbyEmail(string UserName)
    {
        int fac_ID = 0;
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        DataSet ds = datalayer.get_data("sp_getFacultyIDbyEmail", CommandType.StoredProcedure, sp);
        if (ds.Tables[0].Rows.Count > 0)
        {
            fac_ID = Convert.ToInt32(ds.Tables[0].Rows[0]["Faculty_ID"]);
        }
        return fac_ID;
    }

    public String GetFacultyEmailbyID(int FacultyID)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@FacultyID", FacultyID);
        DataSet ds = datalayer.get_data("sp_GetFacultyEmailbyID", CommandType.StoredProcedure, sp);
        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            return ds.Tables[0].Rows[0]["Faculty_email_id"].ToString();
        }
        else
        {
            return "";
        }
    }
    public DataSet GetFacultyImageByUsername(string UserName)
    {

        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        return datalayer.get_data("sp_GetFacultyImageByUsername", CommandType.StoredProcedure, sp);
        //if (ds != null && ds.Tables[0].Rows.Count > 0)
        //{
        //    return ds.Tables[0].Rows[0]["Faculty_Image"].ToString();
        //}
        //else
        //{
        //    return "";
        //}
    }
    public DataSet GetAreaOfInterestOfFacultyByUserName(string UserName)
    {

        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        return datalayer.get_data("sp_GetAreaOfInterestOfFacultyByUserName", CommandType.StoredProcedure, sp);
    }
    public DataSet GetFacultyName(string UserName)
    {

        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        return datalayer.get_data("sp_GetFacultyName", CommandType.StoredProcedure, sp);
    }
    public DataSet GetFacultyInfo(string UserName)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        return datalayer.get_data("sp_GetFacultyInfo", CommandType.StoredProcedure, sp);                    
    }
}
