using Apps.Core.Contracts;
using Apps.Core.Models;
using Apps.Core.Utilities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Apps.Core.Services
{
    public class DBProductService : IProductService
    {
        Product IProductService.Add(Product product)
        {
            product.Id = "p_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string str = $"INSERT INTO PRODUCT(Id,Name,Category,Price,Stock,Status) VALUES(@Id,@Name,@Cat,@Price,@Stock,@Status)";

                SqlCommand cmd = new SqlCommand(str, conn)
                    ;
                cmd.Parameters.AddWithValue("@Id",product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Cat",product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price",product.Price);
                cmd.Parameters.AddWithValue("@Status",product.Status.ToString());              
                cmd.Parameters.AddWithValue("@Stock",product.Stock);

                int rows = cmd.ExecuteNonQuery();
                if 
                    (rows > 0) return product;
                else
                    return null;
            }

        }

     

        //List<Product> IProductService.GetAll()
        //{
        //    //throw new NotImplementedException();
        //    List<Product> products = new List<Product>();
        //    using(SqlConnection conn =  new SqlConnection(_connectionString)){
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = "Select *  from Product";
        //        cmd.Connection = _connectionString;



        //    }
        //}


        List<Product> IProductService.GetAll()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Product", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();

                    p.Id = reader["Id"].ToString();
                    p.Name = reader["Name"].ToString();
                    p.Category = Enum.TryParse<ProductCategoryEnum>(reader["Category"].ToString(), out var cat) ? cat : ProductCategoryEnum.Electronics;
                    p.Price = Convert.ToDecimal(reader["Price"]);
                    p.Stock = Convert. ToInt32(reader["Stock"]);
                    p.Status= Enum.TryParse<ProductCategoryStatus>(reader["Status"].ToString(), out  var statusEnum)? statusEnum : ProductCategoryStatus.Active; 

                    products.Add(p);
                }
            }

            return products;
        }
        public DBProductService(string consString)
        {
            _connectionString = consString;

        }

        //Product IProductService.GetById(string id)
        //{
        //    throw new NotImplementedException();
        //}

        Product IProductService.GetById(string id)
        {
            Product product = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Product WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    product = new Product();

                    product.Id = reader["Id"].ToString();
                    product.Name = reader["Name"].ToString();

                    product.Category = Enum.TryParse<ProductCategoryEnum>(
                        reader["Category"].ToString(),
                        out var cat)
                        ? cat
                        : ProductCategoryEnum.Electronics;

                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);

                    product.Status = Enum.TryParse<ProductCategoryStatus>(
                        reader["Status"].ToString(),
                        out var statusEnum)
                        ? statusEnum
                        : ProductCategoryStatus.Active;
                }
            }

            return product;
        }

        //List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductCategoryStatus? status)
        //{

        //    return null;
        //}

        List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductCategoryStatus? status)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Product
                         WHERE 1=1";

                if (!string.IsNullOrEmpty(text))
                    query += " AND Name LIKE @Text";

                if (category != null)
                    query += " AND Category = @Category";

                if (status != null)
                    query += " AND Status = @Status";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(text))
                    cmd.Parameters.AddWithValue("@Text", "%" + text.Trim() + "%");

                if (category != null)
                    cmd.Parameters.AddWithValue("@Category", category.ToString());

                if (status != null)
                    cmd.Parameters.AddWithValue("@Status", status.ToString());

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();

                    p.Id = reader["Id"].ToString();
                    p.Name = reader["Name"].ToString();

                    p.Category = Enum.TryParse<ProductCategoryEnum>(
                        reader["Category"].ToString(),
                        out var cat)
                        ? cat
                        : ProductCategoryEnum.Electronics;

                    p.Price = Convert.ToDecimal(reader["Price"]);
                    p.Stock = Convert.ToInt32(reader["Stock"]);

                    p.Status = Enum.TryParse<ProductCategoryStatus>(
                        reader["Status"].ToString(),
                        out var statusEnum)
                        ? statusEnum
                        : ProductCategoryStatus.Active;

                    products.Add(p);
                }
            }

            return products;
        }

        bool IProductService.Delete(string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Product WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
                return false;
            }
        }

        bool IProductService.Update(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //conn.Open();
                //string query = "UPDATE PRODUCT SET Name=@Name,Category=@Category,Price=@Price,StocK=@StocK,Status=@Status WHERE Id = @Id";
                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = query;




                //int rows = cmd 


                conn.Open();
                string query = "UPDATE Product SET Name = @Name, Category = @Category, Price = @Price, Stock = @Stock, Status = @Status WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;


            }
            

        }
        private readonly String _connectionString;
       
    }
}
