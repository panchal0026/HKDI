using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
/// <summary>
/// Summary description for clsLeaveNotification
/// </summary>
public class clsLeaveNotification
{
    public int facultyID { get; set; }
    public DateTime from_Date { get; set; }
    public DateTime to_Date { get; set; }
    public bool IsApproved { get; set; }
    public string comments { get; set; }
    public int Student_ID { get; set; }
    
    public bool IsRejected { get; set; }
	public clsLeaveNotification()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void requestLeave(clsLeaveNotification leave) 
    {
        SqlParameter[] sp = new SqlParameter[7];
        sp[0] = new SqlParameter("@Faculty_ID", leave.facultyID);
        sp[1] = new SqlParameter("@Student_ID", leave.Student_ID);
        sp[2] = new SqlParameter("@From_Date", leave.from_Date);
        sp[3] = new SqlParameter("@To_Date", leave.to_Date);
        sp[4] = new SqlParameter("@Comments", leave.comments);
        sp[5] = new SqlParameter("@IsApproved", leave.IsApproved);
        sp[6] = new SqlParameter("@IsRejected",leave.IsRejected);
        datalayer.Execute_NonQuery("sp_requestLeave", CommandType.StoredProcedure, sp);
    }
    public DataSet ListLeave(string UserName) 
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@UserName", UserName);
        return datalayer.get_data("sp_ListLeave", CommandType.StoredProcedure, sp);

    }
    public DataSet ListLeaveNotifications(int Faculty_ID)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@Faculty_ID",Faculty_ID);
        return datalayer.get_data("sp_ListLeaveNotifications",CommandType.StoredProcedure,sp);
    }

    public bool AprroveLeave(int LeaveID) 
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@LeaveID",LeaveID);
        return datalayer.Execute_NonQuery("sp_ApproveLeave", CommandType.StoredProcedure, sp);
    }
    public bool RejectLeave(int LeaveID)
    {
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@LeaveID", LeaveID);
        return datalayer.Execute_NonQuery("sp_RejectLeave", CommandType.StoredProcedure, sp);
    }
    
}