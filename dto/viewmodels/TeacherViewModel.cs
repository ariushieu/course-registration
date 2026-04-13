namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho hiển thị thông tin Giảng viên
    /// </summary>
    public class TeacherViewModel
    {
        public int TeacherID { get; set; }
        public string TeacherCode { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DepartmentName { get; set; }
        public string Degree { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string Status => IsActive ? "Đang làm việc" : "Nghỉ việc";
    }
}
