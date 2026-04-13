using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Schedule - Thời khóa biểu
    /// </summary>
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public int ClassID { get; set; }
        public int ClassroomID { get; set; }
        public int DayOfWeek { get; set; } // 2=Thứ 2, 3=Thứ 3, ..., 8=Chủ nhật
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public CourseClass CourseClass { get; set; }
        public Classroom Classroom { get; set; }

        // Helper property
        public string DayOfWeekText
        {
            get
            {
                switch (DayOfWeek)
                {
                    case 2: return "Thứ 2";
                    case 3: return "Thứ 3";
                    case 4: return "Thứ 4";
                    case 5: return "Thứ 5";
                    case 6: return "Thứ 6";
                    case 7: return "Thứ 7";
                    case 8: return "Chủ nhật";
                    default: return "";
                }
            }
        }
    }
}
