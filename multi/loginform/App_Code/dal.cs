using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for dal
/// </summary>
public class connection
{
    public SqlConnection con;
    public SqlDataAdapter da;
    public SqlCommand cmd;
    public DataSet ds;

   public void mycon()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
        con.Open();
    }
}

    public class userDAL:connection
    {
        
        public int insert_for_signup(userBAL uBAL)
        {
            mycon();
            try
            {
                // Initialize command to check for existing email
                using (cmd = new SqlCommand("SELECT * FROM [user] WHERE email=@em", con))
                {
                    cmd.Parameters.AddWithValue("@em", uBAL.email);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds);

                    // Check if the email already exists
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return -1; // Email already exists
                    }
                }

                // Insert new user data
                using (cmd = new SqlCommand("INSERT INTO [user] (name, email, password, registration_date) VALUES(@nm, @em, @ps, @rdt)", con))
                {
                    cmd.Parameters.AddWithValue("@nm", uBAL.name);
                    cmd.Parameters.AddWithValue("@em", uBAL.email);
                    cmd.Parameters.AddWithValue("@ps", uBAL.password);
                    cmd.Parameters.AddWithValue("@rdt", uBAL.rdt);
                    cmd.ExecuteNonQuery();
                }

                return 1; // Success
            }
            catch (Exception ex)
            {
                // Log the exception (ideally)
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        public DataSet login_for_login(userBAL uBAL)
    {
        mycon();
        try
        {
            cmd= new SqlCommand("Select * from [user] where email=@em AND password=@ps",con);
            cmd.Parameters.AddWithValue("@em",uBAL.email);
            cmd.Parameters.AddWithValue("@ps", uBAL.password);
            da=new SqlDataAdapter(cmd);
            ds=new DataSet();
            da.Fill(ds);

            cmd.ExecuteNonQuery();
            con.Close() ;
            return ds;

        }
        catch
        {
            con.Close();
            con.Dispose();
            throw;
        }
        finally {
            con.Dispose();
            con.Close();
                }

    }
    }
