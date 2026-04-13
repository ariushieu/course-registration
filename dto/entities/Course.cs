using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Course - Học phần (Môn học)
    /// </summary>
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int? DepartmentID { get; set; }
        public int TheoryHours { get; set; }
        public int PracticeHours { get; set; }
        public int? PrerequisiteCourseID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public Course PrerequisiteCourse { get; set; }
    }
}
