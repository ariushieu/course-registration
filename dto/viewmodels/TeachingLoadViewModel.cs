namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho báo cáo khối lượng giảng dạy
    /// </summary>
    public class TeachingLoadViewModel
    {
        public string TeacherCode { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public int TotalClasses { get; set; }
        public int TotalCredits { get; set; }
        public int TotalStudents { get; set; }
        public int TotalHours { get; set; }
        
        // Helper property
        public string Summary => $"{TotalClasses} lớp - {TotalCredits} tín chỉ - {TotalStudents} sinh viên";
    }
}
