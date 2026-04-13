namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho hiển thị Khoa
    /// </summary>
    public class DepartmentViewModel
    {
        public int DepartmentID { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TotalTeachers { get; set; }
        public int TotalCourses { get; set; }
    }
}
