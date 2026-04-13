using System;

namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho hiển thị Thời khóa biểu
    /// </summary>
    public class ScheduleViewModel
    {
        public int ScheduleID { get; set; }
        public string ClassCode { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public string ClassroomCode { get; set; }
        public string ClassroomName { get; set; }
        public int DayOfWeek { get; set; }
        public string DayOfWeekText { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CurrentStudents { get; set; }
        public int MaxStudents { get; set; }
        
        // Helper properties
        public string TimeRange => $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";
        public string DateRange => $"{StartDate:dd/MM/yyyy} - {EndDate:dd/MM/yyyy}";
        public string FullSchedule => $"{DayOfWeekText} {TimeRange}";
    }
}
