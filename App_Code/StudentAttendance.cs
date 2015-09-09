using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for StudentAttendance
/// </summary>
public class StudentAttendance
{
    public int Student_ID { get; set; }
    public int Course_ID { get; set; }
    public int Subject_ID { get; set; }
    public DateTime Lecture_Date { get; set; }
    public int Session_ID { get; set; }
    public int Faculty_ID { get; set; }
    public bool Attendance { get; set; }
         

	public StudentAttendance()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool AddAttendance(StudentAttendance sa)
    {
        SqlParameter[] sp = new SqlParameter[7];
        sp[0] = new SqlParameter("@Student_ID",sa.Student_ID);
        sp[1] = new SqlParameter("@Course_ID",sa.Course_ID);
        sp[2] = new SqlParameter("@Subject_ID",sa.Subject_ID);
        sp[3] = new SqlParameter("@Lecture_Date",sa.Lecture_Date);
        sp[4] = new SqlParameter("@Session_ID",sa.Session_ID);
        sp[5] = new SqlParameter("@Faculty_ID",sa.Faculty_ID);
        sp[6] = new SqlParameter("@Attendance",sa.Attendance);
        return datalayer.Execute_NonQuery("sp_AddAttendance", CommandType.StoredProcedure, sp);
    }
    public DataSet listStudentByClassID(int Course_ID, int Class_ID)
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
}