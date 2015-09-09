using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsEventImage
/// </summary>
public class clsEventImage
{
    public int Event_ID { get; set; }
    public string Event_Image { get; set; }
    public bool IsActive { get; set; }
	public clsEventImage()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool Add_Event_Images(clsEventImage eventImage) 
    { 
        SqlParameter[] sp = new SqlParameter[3];
        sp[0] = new SqlParameter("@EventID", eventImage.Event_ID);
        sp[1] = new SqlParameter("@Img_Path", eventImage.Event_Image);
        sp[2] = new SqlParameter("@IsActive", eventImage.IsActive);
        return datalayer.Execute_NonQuery("sp_Add_Event_Images", CommandType.StoredProcedure, sp);
    }
}