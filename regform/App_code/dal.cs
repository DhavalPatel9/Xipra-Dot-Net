using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.EnterpriseServices.Internal;
/// <summary>
/// Summary description for dal
/// </summary>
public class connection
{

    public SqlConnection con;
    public SqlCommand cmd;
    public SqlDataAdapter da;
    public DataSet ds;

    public void mycon()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
        con.Open();

    }

}
public class regDAL : connection
{
    public int insert_update_registration(regBAL rBAL)
    {
        mycon();
        try
        {
            cmd = new SqlCommand("insert into reg values(@nm,@em,@ps,@gen,@ct,@img,@rdt)", con);
            cmd.Parameters.AddWithValue("@nm", rBAL.name);

            cmd.Parameters.AddWithValue("@em", rBAL.email);
            cmd.Parameters.AddWithValue("@ps", rBAL.password);
            cmd.Parameters.AddWithValue("@gen", rBAL.gender);
            cmd.Parameters.AddWithValue("@ct", rBAL.city);
            cmd.Parameters.AddWithValue("@img", rBAL.image);
            cmd.Parameters.AddWithValue("@rdt", rBAL.regdate);

            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();

            return 1;

        }
        catch (Exception ex)
        {
            con.Close();
            con.Dispose();

            throw;
        }

        finally
        {
            con.Close();
            con.Dispose();


        }
    }
    public DataSet get_reg_details()
    {
        mycon();
        try
        {
            cmd = new SqlCommand("select*from reg", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            con.Dispose();
            return ds;
        }
        catch (Exception ex)
        {
            con.Close(); con.Dispose(); throw;
        }
        finally
        {

            con.Close(); con.Dispose();
        }
    }

    public DataSet get_reg_details_for_search(regBAL rBAL)
    {
        mycon();

        try
        {
            cmd = new SqlCommand("select * from reg where name like @nm", con);
            cmd.Parameters.AddWithValue("@nm", "%" + rBAL.name + "%");

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            con.Dispose();
            return ds;
        }
        catch (Exception ex)
        {
            con.Close(); con.Dispose(); throw;
        }
        finally { con.Close(); con.Dispose(); }

    }
    public string delete_from_reg(regBAL rBAL)
    {
        mycon();
        try
        {
            cmd = new SqlCommand("delete from reg where regid=@id", con);
            cmd.Parameters.AddWithValue("@rid", rBAL.regid);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Delete Successfully";

        }
        catch (Exception ex)
        {
            con.Close(); con.Dispose(); throw;
        }
        finally
        {
            con.Close(); con.Dispose();
        }
    }
    public DataSet get_reg_details_for_edit(regBAL rBAL)


    {

        mycon();

        try
        {
            cmd = new SqlCommand("select * from reg where regid=@rid", con);
            cmd.Parameters.AddWithValue("@rid", rBAL.regid);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            con.Dispose();
            return ds;
        }
        catch (Exception ex)
        {
            con.Close(); con.Dispose(); throw;
        }
        finally
        {
            con.Close(); con.Dispose();
        };


    }
    public int update_reg_(regBAL rBAL)
    {
        mycon();
        try
        {
            cmd = new SqlCommand("update regset name=@nm, email=@em, password=@ps, gender=@gen, city=@ct,image=@img where regid=@rid", con);
            cmd.Parameters.AddWithValue("@rid", rBAL.regid);

            cmd.Parameters.AddWithValue("@nm", rBAL.name);

            cmd.Parameters.AddWithValue("@em", rBAL.email);
            cmd.Parameters.AddWithValue("@ps", rBAL.password);
            cmd.Parameters.AddWithValue("@gen", rBAL.gender);
            cmd.Parameters.AddWithValue("@ct", rBAL.city);
            cmd.Parameters.AddWithValue("@img", rBAL.image);
            cmd.Parameters.AddWithValue("@rdt", rBAL.regdate);

            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();

            return 1;
        }
        catch (Exception ex)
        {
            con.Close();
            con.Dispose();

            throw;
        }

        finally
        {
            con.Close();
            con.Dispose();


        }
    }

}
    


    




    