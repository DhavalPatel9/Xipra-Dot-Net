using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI.WebControls;

public class connection
{
    public SqlConnection conn;
    public SqlDataAdapter da;
/// <summary>
/// Summary description for dal
/// </summary>
    public SqlCommand cmd;
    public DataSet ds;

    public void myconn()
    {
        conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ToString());
        conn.Open();

    }

   }

public class regdal : connection
{
    public int insert(regbal rbal)
    {
        myconn();

        try
        {
            cmd = new SqlCommand("insert into reg values (@nm,@em, @pass,@rdt)", conn);
            cmd.Parameters.AddWithValue("@nm", rbal.name);
            cmd.Parameters.AddWithValue("@em", rbal.email);
            cmd.Parameters.AddWithValue("@pass", rbal.password);
            cmd.Parameters.AddWithValue("@rdt", rbal.rdt);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return 1;

        }

        catch (Exception ex)
        {
            conn.Close();
            conn.Dispose();
            throw;
        }
        finally
        {

            conn.Close();
            conn.Dispose();


        }
    }


    public DataSet login(regbal rbal)
    {
        myconn();
        try
        {
            cmd = new SqlCommand("Select * from reg where email = @em AND password=@ps", conn);
            cmd.Parameters.AddWithValue("@em", rbal.email);
            cmd.Parameters.AddWithValue("@ps", rbal.password);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;





        }
        catch (Exception ex)
        {
            conn.Close();
            conn.Dispose();
            throw;
        }
        finally
        {
            conn.Close();
            conn.Dispose();
        }



    }

    public int update(regbal rbal)
    {
        myconn();

        try
        {
            cmd = new SqlCommand("UPDATE reg SET password = @ps WHERE email = @em", conn);
            cmd.Parameters.AddWithValue("@ps", rbal.password);
            cmd.Parameters.AddWithValue("@em", rbal.email);

            cmd.ExecuteNonQuery();
            conn.Close();
            return 1;

        }
        catch (Exception)
        {
            throw;
        }
        finally
        {

            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }


    public DataSet forgot(regbal rbal)
    {
        myconn();

        try
        {
            cmd = new SqlCommand("select * from reg where email = @em ", conn);

            cmd.Parameters.AddWithValue("@em", rbal.email);


            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Dispose ();
            conn.Close();
            return ds;


        }

        catch (Exception ex)
        {
            conn.Close();
            conn.Dispose();
            throw;
        }
        finally
        {

            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }

    public int reset(regbal rbal)
    {
        myconn();

        try
        {
            cmd = new SqlCommand("update  reg SET password = @ps WHERE email = @em", conn);
            cmd.Parameters.AddWithValue("@ps", rbal.password);
            cmd.Parameters.AddWithValue("@em", rbal.email);

            cmd.ExecuteNonQuery();
            conn.Close();
            return 1;

        }
        catch (Exception)
        {
            conn.Close();
            conn.Dispose();
            throw;
        }
        finally
        {
            conn.Close ();  
            conn.Dispose ();
            
        }
    }
}





