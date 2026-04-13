using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Department - Khoa
    /// </summary>
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime? FoundedDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
