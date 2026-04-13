namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho hiển thị Học phần
    /// </summary>
    public class CourseViewModel
    {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public string DepartmentName { get; set; }
        public int TheoryHours { get; set; }
        public int PracticeHours { get; set; }
        public int TotalHours => TheoryHours + PracticeHours;
        public string PrerequisiteCourseName { get; set; }
        public bool IsActive { get; set; }
        public string Status => IsActive ? "Đang mở" : "Ngừng mở";
    }
}
