using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Core.Contracts;
using Apps.Core.Models;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;


namespace Apps.Core.Services
{
   
    public class DBAuthService : IAuthService
    {
        private readonly string _connectionString;

        public DBAuthService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User Register(User user, string password)
        {
            user.Id = Guid.NewGuid().ToString();
            user.PasswordHash = HashPassword(password);
            user.CreatedAt = DateTime.Now;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Users 
            (Id, FullName, Email, PasswordHash, Role, CreatedAt)
            VALUES (@Id, @FullName, @Email, @PasswordHash, @Role, @CreatedAt)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return user;
        }

        public User Login(string email, string password)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Users WHERE Email=@Email";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();

                    if (VerifyPassword(password, storedHash))
                    {
                        return new User
                        {
                            Id = reader["Id"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        public bool UserExists(string email)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email=@Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // 🔐 Password Hashing
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private bool VerifyPassword(string password, string hash)
        {
            return HashPassword(password) == hash;
        }
    }
}
