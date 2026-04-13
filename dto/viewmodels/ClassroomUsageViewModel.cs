namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho báo cáo sử dụng phòng học
    /// </summary>
    public class ClassroomUsageViewModel
    {
        public string ClassroomCode { get; set; }
        public string ClassroomName { get; set; }
        public string Building { get; set; }
        public int Capacity { get; set; }
        public string RoomType { get; set; }
        public int TotalSchedules { get; set; }
        public int TotalClasses { get; set; }
        public int TotalHours { get; set; }
        
        // Helper properties
        public string UsageSummary => $"{TotalClasses} lớp - {TotalHours} giờ";
        public double UsageRate => TotalHours > 0 ? (double)TotalHours / (45 * 5) * 100 : 0; // Giả sử 1 tuần có 45 tiết
    }
}
