using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
/// <summary>
/// Summary description for clsNewAdmissionClass
/// </summary>
public class clsNewAdmissionClass
{
	public clsNewAdmissionClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int Class_ID { get; set; }
    public string Class_Name { get; set; }
    public int Admission_Year_ID { get; set; }

    public void addClass(clsNewAdmissionClass newClass) 
    {
        SqlParameter[] sp = new SqlParameter[2];
        sp[0] = new SqlParameter("@Class_Name", newClass.Class_Name);
        sp[1] = new SqlParameter("@Admission_Year_ID", newClass.Admission_Year_ID);
        datalayer.Execute_NonQuery("sp_addClass", CommandType.StoredProcedure, sp);
    }

    public DataSet listClassbyAdmissionYearID(int AdmissionYearID) 
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Admission_Year_ID", AdmissionYearID);
        return datalayer.get_data("sp_listClassbyAdmissionYearID", CommandType.StoredProcedure, sp);
    }

}