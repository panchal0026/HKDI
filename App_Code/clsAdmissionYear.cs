using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsAdmissionYear
/// </summary>
public class clsAdmissionYear
{
	public clsAdmissionYear()
	{
		//
		// TODO: Add constructor logic here
		//
	}
     
    public int Admission_Year_ID { get; set; }
    public string Year { get; set; }
    public int Course_ID { get; set; }
    public string YearName { get; set; }
    public bool IsDeleted { get; set; }

    public void addAdmissionYear(clsAdmissionYear newAdmissionYear) 
    {
        SqlParameter[] sp = new SqlParameter[4];
        sp[0] = new SqlParameter("@Year", newAdmissionYear.Year);
        sp[1] = new SqlParameter("@Course_ID", newAdmissionYear.Course_ID);
        sp[2] = new SqlParameter("@YearName", newAdmissionYear.YearName);
        sp[3] = new SqlParameter("@IsDeleted", newAdmissionYear.IsDeleted);

        datalayer.Execute_NonQuery("sp_addAdmissionYear", CommandType.StoredProcedure, sp);
    }

    public DataSet ListCourse() 
    {
        return datalayer.get_data("sp_ListCourse", CommandType.StoredProcedure, null);
    }

    public DataSet ListAdmissionYears() 
    {
        return datalayer.get_data("sp_ListAdmissionYears", CommandType.StoredProcedure, null);
    }

    public void DeleteYear(int Admission_Year_ID) 
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Admission_Year_ID", Admission_Year_ID);
        datalayer.Execute_NonQuery("Sp_DeleteYear", CommandType.StoredProcedure, sp);
    }
}