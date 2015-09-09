using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
/// <summary>
/// Summary description for Test
/// </summary>
public class Test
{
    public string test { get; set; }
    public string test1 { get; set; }

	public Test()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool addval(Test t)
    {
        SqlParameter[] sp = new SqlParameter[2];
        sp[0] = new SqlParameter("@test", t.test);
        sp[1] = new SqlParameter("@test1", t.test1);
        return datalayer.Execute_NonQuery("sp_TestAdd", CommandType.StoredProcedure, sp);
    }

    public DataSet listval() 
    {
        return datalayer.get_data("sp_TestList", CommandType.StoredProcedure, null);
    }
}