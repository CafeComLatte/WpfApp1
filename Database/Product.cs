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

namespace Database
{
    public class Product
    {
        public int updateProductList(DataItem item, OriginDataItem _originItem,CustomEnum.Product selectFlag)
        {
            if(selectFlag == CustomEnum.Product.SELECTED)
            {
                SqlConnection conn = null;

                try
                {
                    using (conn = DBManager.GetConnection())
                    {
                        conn.Open();

                        SqlCommand command = new SqlCommand("UPDATE product_information SET product_name = @product_name, process = @process, weight = @weight, height = @height, image = @image, register = @register " +
                                                             "WHERE product_name = @origin_product_name and process = @origin_process  ", conn);
                        command.Parameters.AddWithValue("@product_name", item.ProductName);
                        command.Parameters.AddWithValue("@process", item.Process);
                        command.Parameters.AddWithValue("@weight", item.Weight);
                        command.Parameters.AddWithValue("@height", item.Height);
                        command.Parameters.AddWithValue("@image", item.Image);
                        command.Parameters.AddWithValue("@register", item.Register);
                        command.Parameters.AddWithValue("@origin_product_name", _originItem.OriginProductName);
                        command.Parameters.AddWithValue("@origin_process", _originItem.OriginProcess);

                        return command.ExecuteNonQuery();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Product.updateProductList() : " + e.ToString());
                }
                finally
                {
                    if (conn != null) conn.Close();
                }
            }
            else if(selectFlag == CustomEnum.Product.UNSELECTED)
            {
                SqlConnection conn = null;

                try
                {
                    using (conn = DBManager.GetConnection())
                    {
                        conn.Open();

                        SqlCommand command = new SqlCommand("INSERT product_information(product_name, process, weight, height, image, register) " +
                                                             "VALUES(@product_name, @process, @weight, @height, @image, @register )  ", conn);
                        command.Parameters.AddWithValue("@product_name", item.ProductName);
                        command.Parameters.AddWithValue("@process", item.Process);
                        command.Parameters.AddWithValue("@weight", item.Weight);
                        command.Parameters.AddWithValue("@height", item.Height);
                        command.Parameters.AddWithValue("@image", item.Image);
                        command.Parameters.AddWithValue("@register", item.Register);

                        return command.ExecuteNonQuery();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Product.updateProductList() : " + e.ToString());
                }
                finally
                {
                    if (conn != null) conn.Close();
                }
            }

            return 0;
        }

        public ObservableCollection<DataItem> getProductList()
        {
            ObservableCollection<DataItem> list = new ObservableCollection<DataItem>();
            
            SqlConnection conn = null;
            SqlDataReader reader = null;

            
            try
            {
                using (conn = DBManager.GetConnection())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT product_name, process, weight, height, image, register FROM product_information", conn);

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataItem item = new DataItem();
                            
                            item.ProductName = reader["product_name"].ToString();
                            item.Process = reader["process"].ToString() ;
                            item.Weight = reader["weight"].ToString();
                            item.Height = reader["height"].ToString();
                            item.Image = reader["image"].ToString();
                            item.Register = reader["register"].ToString();
                            
                            list.Add(item);
                        }

                    }

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Main() Exception Error : " + e);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }

            return list;
        }

        public int deleteProduct(DataItem item)
        {
            SqlConnection conn = null;

            try
            {
                using(conn = DBManager.GetConnection())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("delete from product_information where product_name = @product_name and process = @process ", conn);
                    command.Parameters.AddWithValue("@product_name", item.ProductName);
                    command.Parameters.AddWithValue("@process", item.Process);

                    return command.ExecuteNonQuery();

                }


            }
            catch (Exception e) {
                Console.WriteLine("Product.deleteProduct() Exception Error : " + e.ToString());
            }
            finally
            {
                if (conn != null) conn.Close();
            }


            return 0;
        }
    }

        
}
