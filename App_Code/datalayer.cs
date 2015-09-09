using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for datalayer
/// </summary>
public class datalayer
{
    public static String ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["HKDIConnection"].ToString();
     public static DataSet get_data(String query, CommandType commndtype, SqlParameter[] param)
    {
        SqlConnection conn = new SqlConnection(ConnStr);

        try
        {
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.SelectCommand.CommandType = commndtype;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    adp.SelectCommand.Parameters.Add(param[i]);
                }
            }
            adp.Fill(ds);
            return ds;
        }
        catch(Exception ex)
        {
            return null;
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool Execute_NonQuery(String query, CommandType commndtype, SqlParameter[] param)
    {
        SqlConnection conn = new SqlConnection(ConnStr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = commndtype;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            cmd.ExecuteNonQuery();
            return true;
        }
        catch(Exception e)
        {
            Exception e1 = e;
            return false;
        }
        finally
        {
            conn.Close();

        }

    }


    public static int Execute_NonQuery_ScopeIdentity(String query, CommandType commndtype, SqlParameter[] param,string paramName)
    {
        SqlConnection conn = new SqlConnection(ConnStr);
        try
        {
            int id=0;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = commndtype;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            cmd.ExecuteNonQuery();
            id = Convert.ToInt32(cmd.Parameters[paramName].Value);
            return id;
        }
        catch (Exception e)
        {
            Exception e1 = e;
            return 0;
        }
        finally
        {
            conn.Close();

        }

    }


    public static String Execute_Reader(String query, CommandType commndtype, SqlParameter[] param,int index)
    {
        SqlConnection conn = new SqlConnection(ConnStr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = commndtype;
            SqlDataReader dr;
            string str= "";
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                str = dr.GetString(index); 
            }
            return str;
        }
        catch
        {
            return null;
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool Execute_ReaderBIT(String query, CommandType commndtype, SqlParameter[] param, int index)
    {
        SqlConnection conn = new SqlConnection(ConnStr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = commndtype;
            SqlDataReader dr;
            bool str = true;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                str = dr.GetBoolean(index);
            }
            return str;
        }
        catch
        {
            return true;
        }
        finally
        {
            conn.Close();
        }
    }


    public static object Execute_Scalar(String query, CommandType commndtype, SqlParameter[] param)
    {
        SqlConnection conn = new SqlConnection(ConnStr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = commndtype;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            return cmd.ExecuteScalar();
        }
        catch
        {
            return -1;
        }
        finally
        {
            conn.Close();
        }
    }

}