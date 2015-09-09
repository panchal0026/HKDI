using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsJump
/// </summary>
public class clsJump
{
    public int Student_ID { get; set; }
    public string Reason { get; set; }
    public bool Is_Approved { get; set; }
    public bool Is_Rejected { get; set; }
	public clsJump()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void RequestJump(clsJump jump)
    {
        SqlParameter[] sp = new SqlParameter[4];
        sp[0] = new SqlParameter("@Student_ID",jump.Student_ID);
        sp[1] = new SqlParameter("@Reason",jump.Reason);
        sp[2] = new SqlParameter("@IsApproved",jump.Is_Approved);
        sp[3] = new SqlParameter("@IsRejected", jump.Is_Rejected);
        datalayer.Execute_NonQuery("sp_RequestJump", CommandType.StoredProcedure, sp);
    }
    public DataSet ListJump(string UserName)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        return datalayer.get_data("sp_ListJump", CommandType.StoredProcedure, sp);

    }
    public bool AllowJump(int Student_ID)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Student_ID", Student_ID);
        return datalayer.Execute_NonQuery("sp_AllowJump", CommandType.StoredProcedure, sp);
    }
    public DataSet ListJumpRequests(clsJump j) 
    {
        return datalayer.get_data("sp_ListJumpRequests",CommandType.StoredProcedure,null);
    }
    public bool RejectJump(int Student_ID)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Student_ID", Student_ID);
        return datalayer.Execute_NonQuery("sp_RejectJump", CommandType.StoredProcedure, sp);
    }
}