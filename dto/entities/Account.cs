using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Account - Tài khoản đăng nhập
    /// </summary>
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }

        // Navigation property
        public Role Role { get; set; }
    }
}
