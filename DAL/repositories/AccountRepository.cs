using System;
using System.Data;
using System.Data.SqlClient;
using CourseRegistration.DAL.Data;
using CourseRegistration.DAL.Interfaces;
using CourseRegistration.DTO.Entities;

namespace CourseRegistration.DAL.Repositories
{
    /// <summary>
    /// Repository xử lý thao tác với bảng Account
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        public Account GetByUsername(string username)
        {
            Account account = null;

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = @"
                    SELECT a.AccountID, a.Username, a.Password, a.RoleID, a.IsActive, 
                           a.CreatedDate, a.LastLogin, r.RoleName
                    FROM Account a
                    INNER JOIN Role r ON a.RoleID = r.RoleID
                    WHERE a.Username = @Username";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    account = new Account
                    {
                        AccountID = (int)reader["AccountID"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        RoleID = (int)reader["RoleID"],
                        IsActive = (bool)reader["IsActive"],
                        CreatedDate = (DateTime)reader["CreatedDate"],
                        LastLogin = reader["LastLogin"] != DBNull.Value ? (DateTime?)reader["LastLogin"] : null,
                        Role = new Role
                        {
                            RoleID = (int)reader["RoleID"],
                            RoleName = reader["RoleName"].ToString()
                        }
                    };
                }
            }

            return account;
        }

        public Account GetById(int accountId)
        {
            Account account = null;

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = @"
                    SELECT a.AccountID, a.Username, a.Password, a.RoleID, a.IsActive, 
                           a.CreatedDate, a.LastLogin, r.RoleName
                    FROM Account a
                    INNER JOIN Role r ON a.RoleID = r.RoleID
                    WHERE a.AccountID = @AccountID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    account = new Account
                    {
                        AccountID = (int)reader["AccountID"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        RoleID = (int)reader["RoleID"],
                        IsActive = (bool)reader["IsActive"],
                        CreatedDate = (DateTime)reader["CreatedDate"],
                        LastLogin = reader["LastLogin"] != DBNull.Value ? (DateTime?)reader["LastLogin"] : null,
                        Role = new Role
                        {
                            RoleID = (int)reader["RoleID"],
                            RoleName = reader["RoleName"].ToString()
                        }
                    };
                }
            }

            return account;
        }

        public bool UpdateLastLogin(int accountId)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = "UPDATE Account SET LastLogin = @LastLogin WHERE AccountID = @AccountID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LastLogin", DateTime.Now);
                cmd.Parameters.AddWithValue("@AccountID", accountId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Create(Account account)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Account (Username, Password, RoleID, IsActive, CreatedDate)
                    VALUES (@Username, @Password, @RoleID, @IsActive, @CreatedDate)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@RoleID", account.RoleID);
                cmd.Parameters.AddWithValue("@IsActive", account.IsActive);
                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Update(Account account)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = @"
                    UPDATE Account 
                    SET Username = @Username, Password = @Password, RoleID = @RoleID, IsActive = @IsActive
                    WHERE AccountID = @AccountID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", account.AccountID);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@RoleID", account.RoleID);
                cmd.Parameters.AddWithValue("@IsActive", account.IsActive);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Delete(int accountId)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = "DELETE FROM Account WHERE AccountID = @AccountID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
