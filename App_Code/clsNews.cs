using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for clsNews
/// </summary>
public class clsNews
{
    public string News_Title { get; set; }
    public string News_Description { get; set; }
    public DateTime News_Date { get; set; }
	public clsNews()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool AddNews(clsNews n)
    {
        SqlParameter[] sp = new SqlParameter[3];
        sp[0] = new SqlParameter("@News_Title", n.News_Title);
        sp[1] = new SqlParameter("@News_Description", n.News_Description);
        sp[2] = new SqlParameter("@News_Date", n.News_Date);
        return datalayer.Execute_NonQuery("sp_AddNews", CommandType.StoredProcedure, sp);

    }
    public DataSet ListNews()
    {
        return datalayer.get_data("sp_ListNews", CommandType.StoredProcedure, null);
    }
   
}


