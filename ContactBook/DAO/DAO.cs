using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
    public static class DAO
    {
        public static AppSettingsReader aps = new AppSettingsReader();

        public static string constr = "";
        static DAO() {
            constr = aps.GetValue("myconnection", typeof(string)).ToString();
        
        }
        public static SqlConnection GetConnection(){
            SqlConnection con = new SqlConnection(constr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();  
            }
            return con;

        
        }
        public static int IDU(string sql, SqlParameter[] param)
        {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {

                    cmd.CommandText = sql;
                    if (param!=null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        return i;

                    }
                    catch (Exception ex)
                    {
                        
                        throw ex;
                    }


                }

            }
            
            
            

        }
        public static DataTable GetContacts(string sql, SqlParameter[] param) {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    if (param!=null)
                    {
                        cmd.Parameters.AddRange(param);  
                    }
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                       
                        return dt;

                    }
                    catch (Exception ex)
                    {
                        
                        throw ex;
                    }
                    
                    
                }
                
            }
        
        }
    }
}
