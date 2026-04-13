namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho hiển thị Lớp học phần
    /// </summary>
    public class CourseClassViewModel
    {
        public int ClassID { get; set; }
        public string ClassCode { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public string TeacherName { get; set; }
        public string DepartmentName { get; set; }
        public int MaxStudents { get; set; }
        public int CurrentStudents { get; set; }
        public int AvailableSlots => MaxStudents - CurrentStudents;
        public string Status { get; set; }
        public string SemesterName { get; set; }
        public string RegistrationStatus => CurrentStudents >= MaxStudents ? "Đã đầy" : "Còn chỗ";
    }
}
