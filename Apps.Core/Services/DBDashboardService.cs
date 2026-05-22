using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Core.Contracts;
using Apps.Core.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Apps.Core.Services
{
    

    public class DBDashboardService : IDashboardService
    {
        private readonly string _connectionString;

        public DBDashboardService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int GetTotalOrders()
        {
            using SqlConnection con = new SqlConnection(_connectionString);

            string query = "SELECT COUNT(*) FROM Orders";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            return (int)cmd.ExecuteScalar();
        }

        public decimal GetTotalRevenue()
        {
            using SqlConnection con = new SqlConnection(_connectionString);

            string query = @"
        SELECT ISNULL(SUM(Quantity * UnitPrice),0)
        FROM OrderItems";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public int GetTotalProductsSold()
        {
            using SqlConnection con = new SqlConnection(_connectionString);

            string query = @"
        SELECT ISNULL(SUM(Quantity),0)
        FROM OrderItems";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<Product> GetLowStockProducts()
        {
            List<Product> products = new List<Product>();

            using SqlConnection con = new SqlConnection(_connectionString);

            string query = @"
        SELECT * FROM Product
        WHERE Stock <= 5";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = reader["Id"].ToString(),
                    Name = reader["Name"].ToString(),
                    Stock = Convert.ToInt32(reader["Stock"])
                });
            }

            return products;
        }

        public DataTable GetRecentOrders()
        {
            using SqlConnection con = new SqlConnection(_connectionString);

            string query = @"
        SELECT TOP 10
        Orders.Id,
        Customer.Name AS Customer,
        Orders.OrderDate,
        Orders.Status
        FROM Orders
        INNER JOIN Customer
        ON Orders.CustomerId = Customer.Id
        ORDER BY Orders.OrderDate DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
