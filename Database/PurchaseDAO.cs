using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class PurchaseDAO
    {
        public List<PurchaseVO> Select()
        {
            SqlConnection conn = null;

            try
            {
                using (conn = DBManager.GetConnection())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("Select * from purchase", conn);

                    SqlDataAdapter adapter = new SqlDataAdapter();

                    adapter.SelectCommand = command;

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    List<PurchaseVO> list = new List<PurchaseVO>();
                    list = (from DataRow dr in dt.Rows
                            select new PurchaseVO()
                            {
                                Id = dr["id"].ToString(),
                                ProductName = dr["product_name"].ToString(),
                                Contents = dr["contents"].ToString(),
                                Image = dr["image"].ToString(),
                                Price = dr["price"].ToString(),
                                TotalPrice = dr["total_price"].ToString(),
                                Count = dr["count"].ToString(),
                                PaymentDate = dr["payment_date"].ToString(),
                                PaymentTime = dr["payment_time"].ToString(),
                                SysDate = dr["sys_date"].ToString()
                            }).ToList();


                    return list;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Purchase.select() : " + e.ToString());
            }
            finally
            {
                if (conn != null) conn.Close();
            }

            return null;
        }
    }
}
