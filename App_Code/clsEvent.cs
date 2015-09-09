using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsEvent
/// </summary>
public class clsEvent
{
    public string Event_Title { get; set; }
    public string Event_Description { get; set; }
    public DateTime Event_Date { get; set; }
    public string Organized_by { get; set; }
    public string Event_Image { get; set; }

	public clsEvent()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool addEvent(clsEvent e) 
    {
        SqlParameter[] sp = new SqlParameter[5];
        sp[0] = new SqlParameter("@Event_Title",e.Event_Title);
        sp[1] = new SqlParameter("@Event_Description", e.Event_Description);
        sp[2] = new SqlParameter("@Event_Date", e.Event_Date);
        sp[3] = new SqlParameter("@Organized_by", e.Organized_by);
        sp[4] = new SqlParameter("@Event_Image", e.Event_Image);
        return datalayer.Execute_NonQuery("sp_AddEvent", CommandType.StoredProcedure, sp);


    }
    public DataSet listEvent() 
    {
        return datalayer.get_data("sp_ListEvent", CommandType.StoredProcedure, null);
    }
}