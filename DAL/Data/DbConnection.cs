using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CourseRegistration.DAL.Data
{
    internal class DbConnection
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;

        /// <summary>
        /// Tạo và trả về một đối tượng kết nối mới. 
        /// Best Practice: Luôn tạo mới và để trong khối 'using' ở tầng Repository.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Bonus: Hàm check kết nối (dùng cho lúc test hoặc lúc khởi động app)
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    //Console.WriteLine("Database connection successful.");
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
