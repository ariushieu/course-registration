using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Role - Vai trò người dùng
    /// </summary>
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
