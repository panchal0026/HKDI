using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for clsStudentMarks
/// </summary>
public class clsStudentMarks
{
    public int Student_ID { get; set; }
    public int Course_ID { get; set; }
    public int Subject_ID { get; set; }
    public DateTime Exam_Date { get; set; }
    public int Faculty_ID { get; set; }
    public string Obtained_Marks { get; set; }
	public clsStudentMarks()
	{
		//
		// TODO: Add constructor logic here
		//
	}
   
    public bool AddStudentMarks(clsStudentMarks sm) 
    {
        SqlParameter[] sp = new SqlParameter[6];
        sp[0] = new SqlParameter("@Student_ID",sm.Student_ID);
        sp[1] = new SqlParameter("@Course_ID",sm.Course_ID);
        sp[2] = new SqlParameter("@Subject_ID",sm.Subject_ID);
        sp[3] = new SqlParameter("@Exam_Date",sm.Exam_Date);
        sp[4] = new SqlParameter("@Faculty_ID",sm.Faculty_ID);
        sp[5] = new SqlParameter("@Obtained_Marks",sm.Obtained_Marks);
        return datalayer.Execute_NonQuery("sp_AddStudentMarks", CommandType.StoredProcedure, sp);
    }


}












