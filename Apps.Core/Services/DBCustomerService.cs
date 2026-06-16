
using Apps.Core.Models;
using Apps.Core.Utilities;
using Apps.Core.Contracts;
using Apps.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Apps.Core.Services
{
    public class DBCustomerService : ICustomerService
    {
        void ICustomerService.Add(Customer customer)
        {
            customer.Id = "C_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            string connectionString = ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string str = @"INSERT INTO Customer(Id, Name, Email, Phone, Address)
                       VALUES(@Id, @Name, @Email, @Phone, @Address)";

                SqlCommand cmd = new SqlCommand(str, conn);

                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Address", customer.Address);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {

                    System.Windows.MessageBox.Show("Customer added successfully!");
                }
                else
                {

                    System.Windows.MessageBox.Show("Failed to add customer!");
                }
            }
        }


        void ICustomerService.Delete(string id)
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Customer WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    System.Windows.MessageBox.Show("Customer deleted successfully!");
                }
                else
                {
                    System.Windows.MessageBox.Show("Customer not found!");
                }
            }
        }

        List<Customer> ICustomerService.GetAll()
        {
            List<Customer> customers = new List<Customer>();

            string connectionString =
                ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Id, Name, Email, Phone, Address FROM Customer";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        Id = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()
                    };

                    customers.Add(customer);

                }
            }

            return customers;
        }

        Customer ICustomerService.GetById(string id)
        {
            Customer customer = null;

            string connectionString =
                ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Id, Name, Email, Phone, Address 
                         FROM Customer 
                         WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    customer = new Customer
                    {
                        Id = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()
                    };
                }
            }

            return customer;
        }

        List<Customer> ICustomerService.Search(string query)
        {
            List<Customer> customers = new List<Customer>();

            string connectionString =
                ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                
                string sql = @"SELECT Id, Name, Email, Phone, Address
                       FROM Customer
                       WHERE Name LIKE @query
                          OR Email LIKE @query
                          OR Phone LIKE @query
                          OR Id LIKE @query";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@query", "%" + query + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        Id = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()
                    });
                }
            }

            return customers;
        }

        void ICustomerService.Update(Customer customer)
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["ElectronicStoreDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE Customer 
            SET Name = @Name,
                Email = @Email,
                Phone = @Phone,
                Address = @Address
            WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Address", customer.Address);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    System.Windows.MessageBox.Show("Customer updated successfully!");
                }
                else
                {
                    System.Windows.MessageBox.Show("Update failed! Customer not found.");
                }
            }
        }
    }
}
