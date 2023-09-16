using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DBManager
    {

        public static SqlConnection conn = null;

        public static SqlConnection GetConnection()
        {

            try
            {
                    Console.WriteLine("DB NULL");
                    conn = new SqlConnection(ConfigurationManager.ConnectionStrings["production"].ConnectionString);
                
            }catch(Exception e){
                Console.WriteLine("DB connection Error : " + e);
            }
            
            return conn;
        }
    }
}
