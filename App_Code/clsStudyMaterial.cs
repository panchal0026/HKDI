using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsStudyMaterial
/// </summary>
public class clsStudyMaterial
{
    public int Course_ID { get; set; }
    public int Faculty_ID { get; set; }
    public int Subject_ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string File_Path { get; set; }
    public DateTime Upload_Date { get; set; }
	public clsStudyMaterial()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool AddStudyMaterial(clsStudyMaterial sm) 
    {
        SqlParameter[] sp = new SqlParameter[7];
        sp[0] = new SqlParameter("@Course_ID",sm.Course_ID);
        sp[1] = new SqlParameter("@Faculty_ID",sm.Faculty_ID);
        sp[2] = new SqlParameter("@Subject_ID",sm.Subject_ID);
        sp[3] = new SqlParameter("@Title", sm.Title);
        sp[4] = new SqlParameter("@Description",sm.Description);
        sp[5] = new SqlParameter("@File_Path",sm.File_Path);
        sp[6] = new SqlParameter("@Upload_Date",sm.Upload_Date);
        return datalayer.Execute_NonQuery("sp_AddStudyMaterial", CommandType.StoredProcedure, sp);


    }
    public DataSet ListMaterial(int Faculty_ID) 
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Faculty_ID",Faculty_ID);
        return datalayer.get_data("sp_ListMaterial", CommandType.StoredProcedure, sp);
    }
}