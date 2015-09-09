using System;   
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



/// <summary>
/// Summary description for clsStudent
/// </summary>
public class clsStudent
{
    public int Admission_Year_ID { get; set; }
    public string Student_name { get; set; }
    public string Contact_No { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Class_ID { get; set; }
    public int Current_Subject_ID { get; set; }
    public int Faculty_ID{ get; set; }
 
	public clsStudent()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool addStudent(clsStudent s)
    {
        SqlParameter[] sp = new SqlParameter[8];
        sp[0] = new SqlParameter("@Admission_Year_ID", s.Admission_Year_ID);
        sp[1] = new SqlParameter("@Student_Name", s.Student_name);
        sp[2] = new SqlParameter("@Contact_No",s.Contact_No);
        sp[3] = new SqlParameter("@Email",s.Email);
        sp[4] = new SqlParameter("@Password", s.Password);
        sp[5] = new SqlParameter("@Class_ID",s.Class_ID);
        sp[6] = new SqlParameter("@Current_Subject_ID",s.Current_Subject_ID);
        sp[7] = new SqlParameter("@Faculty_ID",s.Faculty_ID);
       
        return datalayer.Execute_NonQuery("sp_addStudent", CommandType.StoredProcedure, sp);
    }
    public DataSet listStudent()
    {
        return datalayer.get_data("sp_listStudent", CommandType.StoredProcedure, null);
    }
    public bool removeStudent(string Email) 
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Email",Email);
        return datalayer.Execute_NonQuery("sp_removeStudent", CommandType.StoredProcedure, sp);
    }

    public DataSet listStudentByClassID(int Course_ID,int Class_ID)
    {
        SqlParameter[] sp = new SqlParameter[2];
        sp[0] = new SqlParameter("@Course_ID", Course_ID);
        sp[1] = new SqlParameter("@Class_ID", Class_ID);
        return datalayer.get_data("sp_listStudentByClassID", CommandType.StoredProcedure, sp);
    }


    public DataSet listClassIDbyCourse(int Course_ID)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Admission_Year_ID", Course_ID);
        return datalayer.get_data("sp_listClassIDbyCourse", CommandType.StoredProcedure, sp);
    }

    public DataSet listClassIDbyAdmissionProgramme(int Admission_Year_ID)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Admission_Year_ID", Admission_Year_ID);
        return datalayer.get_data("sp_listClassIDbyAdmissionProgramme", CommandType.StoredProcedure, sp);
    }
    
    public DataSet SelectAdYear()
    {
        return datalayer.get_data("sp_SelectAdYear", CommandType.StoredProcedure, null);
    }
    public DataSet listStudentByAdmission_Year_ID(int Admission_Year_ID, int Class_ID)
    {
        SqlParameter[] sp = new SqlParameter[2];
        sp[0] = new SqlParameter("@Admission_Year_ID",Admission_Year_ID);
        sp[1] = new SqlParameter("@Class_ID",Class_ID);
        return datalayer.get_data("sp_listStudentByAdmission_Year_ID",CommandType.StoredProcedure,sp);
    }
    public DataSet GetStudentInfoByUsername(string UserName)
    {

        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        DataSet ds = datalayer.get_data("sp_GetStudentInfoByUsername", CommandType.StoredProcedure, sp);
        return ds;
    }
    public DataSet StudentAttendance(int Student_ID) 
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Student_ID",Student_ID);
        DataSet ds = datalayer.get_data("sp_StudentAttendance",CommandType.StoredProcedure,sp);
        return ds;
    }
}