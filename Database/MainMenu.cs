using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class MainMenu
    {

        public List<MenuItemVO> getMenuList()
        {
            List<MenuItemVO> menuList = new List<MenuItemVO>();

            SqlConnection conn = null;
            SqlDataReader reader = null;

            try
            {
                using(conn = DBManager.GetConnection())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT menu_id, menu_type, menu_name FROM menu_information", conn);
                    
                    using(reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MenuItemVO item = new MenuItemVO();

                            item.MenuID = reader["menu_id"].ToString();
                            item.MenuType = reader["menu_type"].ToString();
                            item.MenuName = reader["menu_name"].ToString() ;

                            menuList.Add(item);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("getMenuList() Exception Error " + e.ToString());
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }


            return menuList;
        }
    }
}
