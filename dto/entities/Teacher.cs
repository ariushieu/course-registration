using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Teacher - Giảng viên
    /// </summary>
    public class Teacher
    {
        public int TeacherID { get; set; }
        public int AccountID { get; set; }
        public string TeacherCode { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? DepartmentID { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Degree { get; set; } // Học vị: Thạc sĩ, Tiến sĩ
        public string Title { get; set; } // Chức danh: Giảng viên, PGS, GS
        public DateTime? HireDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public Account Account { get; set; }
        public Department Department { get; set; }
    }
}
