using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
using Common.Enum;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Security.Cryptography;

namespace Database
{
    public class Product
    {
        
        public List<ProductVO> SelectProduct(string table_name)
        {
            SqlConnection conn = null;

            try
            {
                using (conn = DBManager.GetConnection())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("Select * from " + table_name, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter();

                    adapter.SelectCommand = command;

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    List<ProductVO> list = new List<ProductVO>();
                    list = (from DataRow dr in dt.Rows select new ProductVO()
                    {
                        Id = dr["id"].ToString(),
                        Name = dr["name"].ToString(),
                        Price = dr["price"].ToString(),
                        Contents = dr["contents"].ToString(),
                        Image = dr["image"].ToString(),
                        SysDate = dr["sys_date"].ToString() 

                    }).ToList();
                    
                    return list;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Product.selectProductList() : " + e.ToString());
            }
            finally
            {
                if (conn != null) conn.Close();
            }

            return null;
        }


    }

    
       
}
