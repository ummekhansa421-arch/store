using Apps.Core.Contracts;
using Apps.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Core.Services
{
    public class DBOrderService : IOrderService
    {
        private readonly string _connectionString;

        public DBOrderService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateOrder(Order order, List<OrderItem> items)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                using (SqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert Order
                        SqlCommand cmdOrder = new SqlCommand(@"
                        INSERT INTO Orders (Id, CustomerId, OrderDate, Status, PaymentMethod)
                        VALUES (@Id, @CustomerId, @OrderDate, @Status, @PaymentMethod)
                    ", con, tx);

                        cmdOrder.Parameters.AddWithValue("@Id", order.Id);
                        cmdOrder.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                        cmdOrder.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                        cmdOrder.Parameters.AddWithValue("@Status", order.Status);
                        cmdOrder.Parameters.AddWithValue("@PaymentMethod", order.PaymentMethod);

                        cmdOrder.ExecuteNonQuery();

                        // 2. Insert OrderItems
                        foreach (var item in items)
                        {
                            SqlCommand cmdItem = new SqlCommand(@"
                            INSERT INTO OrderItems (Id, OrderId, ProductId, Quantity, UnitPrice)
                            VALUES (@Id, @OrderId, @ProductId, @Quantity, @UnitPrice)
                        ", con, tx);

                            cmdItem.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                            cmdItem.Parameters.AddWithValue("@OrderId", order.Id);
                            cmdItem.Parameters.AddWithValue("@ProductId", item.ProductId);
                            cmdItem.Parameters.AddWithValue("@Quantity", item.Quantity);
                            cmdItem.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);

                            cmdItem.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
