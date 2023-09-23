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
    public class EventContentDAO
    {
        public List<EventContent> Select()
        {
            SqlConnection conn = null;

            try
            {
                using (conn = DBManager.GetConnection())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("Select * from event_content", conn);

                    SqlDataAdapter adapter = new SqlDataAdapter();

                    adapter.SelectCommand = command;

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    List<EventContent> list = new List<EventContent>();
                    list = (from DataRow dr in dt.Rows
                            select new EventContent()
                            {
                                Image = dr["image"].ToString()
                            }).ToList();

                    return list;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("EventContent.select() : " + e.ToString());
            }
            finally
            {
                if (conn != null) conn.Close();
            }

            return null;
        }
    }
}
